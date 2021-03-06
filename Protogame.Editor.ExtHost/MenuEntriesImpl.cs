﻿using System.Threading.Tasks;
using Grpc.Core;
using Protogame.Editor.Grpc.ExtensionHost;
using Protoinject;
using Protogame.Editor.Api.Version1.Menu;
using System.Linq;

namespace Protogame.Editor.ExtHost
{
    public class MenuEntriesImpl : MenuEntries.MenuEntriesBase
    {
        private readonly IMenuProvider[] _menuProvider;

        public MenuEntriesImpl(IMenuProvider[] menuProvider)
        {
            _menuProvider = menuProvider;
        }

        public override async Task<GetMenuItemsResponse> GetMenuItems(GetMenuItemsRequest request, ServerCallContext context)
        {
            var resp = new GetMenuItemsResponse();

            if (_menuProvider == null)
            {
                return resp;
            }

            foreach (var mp in _menuProvider)
            {
                resp.MenuItems.AddRange(mp.GetMenuItems().Select(x => new Grpc.ExtensionHost.MenuItem
                {
                    Id = x.Path.GetHashCode(),
                    Path = x.Path,
                    Text = "",
                    Enabled = x.Enabled,
                    Order = x.Order
                }));
            }

            return resp;
        }

        public override async Task<MenuItemClickedResponse> MenuItemClicked(MenuItemClickedRequest request, ServerCallContext context)
        {
            if (_menuProvider != null)
            {
                foreach (var mp in _menuProvider)
                {
                    foreach (var me in mp.GetMenuItems())
                    {
                        if (request.MenuItemId == me.Path.GetHashCode())
                        {
                            me.Handler?.Invoke(me);
                            return new MenuItemClickedResponse();
                        }
                    }
                }
            }

            return new MenuItemClickedResponse();
        }
    }
}
