﻿namespace ShipStationAccess.V2.Models.Command
{
	internal sealed class ShipStationCommand
	{
		public static readonly ShipStationCommand Unknown = new ShipStationCommand( string.Empty );
		public static readonly ShipStationCommand GetOrders = new ShipStationCommand( "/Orders/List" );
		public static readonly ShipStationCommand GetTags = new ShipStationCommand( "/Accounts/ListTags " );
		public static readonly ShipStationCommand CreateUpdateOrder = new ShipStationCommand( "/Orders/CreateOrder" );
		public static readonly ShipStationCommand GetStores = new ShipStationCommand( "/Stores" );
        public static readonly ShipStationCommand CreateLabel = new ShipStationCommand("/shipments/createlabel");
        public static readonly ShipStationCommand VoidLabel = new ShipStationCommand("/shipments/voidlabel");

        private ShipStationCommand( string command )
		{
			this.Command = command;
		}

		public string Command{ get; private set; }
	}
}