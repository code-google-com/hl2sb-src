// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EGameConnectSteamResponse : int
	{
		k_EGameConnectSteamResponse_WaitingForResponse = 0,
		k_EGameConnectSteamResponse_AuthorizedToPlay = 1,
		k_EGameConnectSteamResponse_Denied = 2,
		k_EGameConnectSteamResponse_ExceededReasonableTime_StillWaiting = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ConnectedUserInfo_t
	{
		public Int32 m_cubConnectedUserInfo;
		public Int32 m_nCountOfGuestUsers;
		public UInt64 m_SteamID;
		public UInt32 m_unIPPublic;
		public UInt32 m_nFrags;
		public double m_flConnectTime;
		public EGameConnectSteamResponse m_eGameConnectSteamResponse;
		public EDenyReason m_eDenyReason;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientGameServerVTable
	{
		public IntPtr GetHSteamUser0;
		public IntPtr GetSteamID1;
		public IntPtr LogOn2;
		public IntPtr LogOff3;
		public IntPtr BLoggedOn4;
		public IntPtr BSecure5;
		public IntPtr GetLogonState6;
		public IntPtr BConnected7;
		public IntPtr RaiseConnectionPriority8;
		public IntPtr ResetConnectionPriority9;
		public IntPtr SetCellID10;
		public IntPtr TrackSteamUsageEvent11;
		public IntPtr SendUserConnectAndAuthenticate12;
		public IntPtr CreateUnauthenticatedUserConnection13;
		public IntPtr SendUserDisconnect14;
		public IntPtr BSetServerType15;
		public IntPtr BUpdateUserData16;
		public IntPtr UpdateStatus17;
		public IntPtr UpdateSpectatorPort18;
		public IntPtr SetGameTags19;
		public IntPtr SetGameData20;
		public IntPtr SetCountOfSimultaneousGuestUsersPerSteamAccount21;
		public IntPtr EnumerateConnectedUsers22;
		public IntPtr GetGameplayStats23;
		public IntPtr GetServerReputation24;
		public IntPtr RequestUserGroupStatus25;
		public IntPtr GetPublicIP26;
		public IntPtr GetAuthSessionTicket27;
		public IntPtr BeginAuthSession28;
		public IntPtr EndAuthSession29;
		public IntPtr CancelAuthTicket30;
		public IntPtr IsUserSubscribedAppInTicket31;
		public IntPtr _GetUserAchievementStatus32;
		public IntPtr _GSSetSpawnCount33;
		public IntPtr _GSGetSteam2GetEncryptionKeyToSendToNewClient34;
		public IntPtr _GSSendSteam2UserConnect35;
		public IntPtr _GSSendSteam3UserConnect36;
		public IntPtr _GSSendUserConnect37;
		public IntPtr _GSRemoveUserConnect38;
		public IntPtr _GSUpdateStatus39;
		public IntPtr _GSCreateUnauthenticatedUser40;
		public IntPtr _GSSendUserDisconnect41;
		private IntPtr DTorIClientGameServer42;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTGAMESERVER_INTERFACE_VERSION001")]
	public class IClientGameServer : InteropHelp.NativeWrapper<IClientGameServerVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser( IntPtr thisptr );
		public Int32 GetHSteamUser(  ) 
		{
			return this.GetFunction<NativeGetHSteamUser>( this.Functions.GetHSteamUser0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID1 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOn( IntPtr thisptr );
		public void LogOn(  ) 
		{
			this.GetFunction<NativeLogOn>( this.Functions.LogOn2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff( IntPtr thisptr );
		public void LogOff(  ) 
		{
			this.GetFunction<NativeLogOff>( this.Functions.LogOff3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn4 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSecure( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BSecure(  ) 
		{
			return this.GetFunction<NativeBSecure>( this.Functions.BSecure5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELogonState NativeGetLogonState( IntPtr thisptr );
		public ELogonState GetLogonState(  ) 
		{
			return this.GetFunction<NativeGetLogonState>( this.Functions.GetLogonState6 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBConnected( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BConnected(  ) 
		{
			return this.GetFunction<NativeBConnected>( this.Functions.BConnected7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeRaiseConnectionPriorityE( IntPtr thisptr, EConnectionPriority eConnectionPriority );
		public Int32 RaiseConnectionPriority( EConnectionPriority eConnectionPriority ) 
		{
			return this.GetFunction<NativeRaiseConnectionPriorityE>( this.Functions.RaiseConnectionPriority8 )( this.ObjectAddress, eConnectionPriority ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeResetConnectionPriorityI( IntPtr thisptr, Int32 hRaiseConnectionPriorityPrev );
		public void ResetConnectionPriority( Int32 hRaiseConnectionPriorityPrev ) 
		{
			this.GetFunction<NativeResetConnectionPriorityI>( this.Functions.ResetConnectionPriority9 )( this.ObjectAddress, hRaiseConnectionPriorityPrev ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCellIDU( IntPtr thisptr, UInt32 cellID );
		public void SetCellID( UInt32 cellID ) 
		{
			this.GetFunction<NativeSetCellIDU>( this.Functions.SetCellID10 )( this.ObjectAddress, cellID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackSteamUsageEventEBU( IntPtr thisptr, ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV, UInt32 cubKV );
		public void TrackSteamUsageEvent( ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV ) 
		{
			this.GetFunction<NativeTrackSteamUsageEventEBU>( this.Functions.TrackSteamUsageEvent11 )( this.ObjectAddress, eSteamUsageEvent, pubKV, (UInt32) pubKV.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserConnectAndAuthenticateUBUC( IntPtr thisptr, UInt32 unIPClient, Byte[] pvAuthBlob, UInt32 cubAuthBlobSize, ref UInt64 pSteamIDUser );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendUserConnectAndAuthenticate( UInt32 unIPClient, Byte[] pvAuthBlob, ref CSteamID pSteamIDUser ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeSendUserConnectAndAuthenticateUBUC>( this.Functions.SendUserConnectAndAuthenticate12 )( this.ObjectAddress, unIPClient, pvAuthBlob, (UInt32) pvAuthBlob.Length, ref s0 ); pSteamIDUser = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateUnauthenticatedUserConnection( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID CreateUnauthenticatedUserConnection(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeCreateUnauthenticatedUserConnection>( this.Functions.CreateUnauthenticatedUserConnection13 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendUserDisconnectC( IntPtr thisptr, UInt64 steamIDUser );
		public void SendUserDisconnect( CSteamID steamIDUser ) 
		{
			this.GetFunction<NativeSendUserDisconnectC>( this.Functions.SendUserDisconnect14 )( this.ObjectAddress, steamIDUser.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSetServerTypeUUUUUSSB( IntPtr thisptr, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BSetServerType( UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode ) 
		{
			return this.GetFunction<NativeBSetServerTypeUUUUUSSB>( this.Functions.BSetServerType15 )( this.ObjectAddress, unServerFlags, unGameIP, unGamePort, unSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBUpdateUserDataCSU( IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BUpdateUserData( CSteamID steamIDUser, string pchPlayerName, UInt32 uScore ) 
		{
			return this.GetFunction<NativeBUpdateUserDataCSU>( this.Functions.BUpdateUserData16 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateStatusIIISSS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName );
		public void UpdateStatus( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName ) 
		{
			this.GetFunction<NativeUpdateStatusIIISSS>( this.Functions.UpdateStatus17 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateSpectatorPortU( IntPtr thisptr, UInt16 unSpectatorPort );
		public void UpdateSpectatorPort( UInt16 unSpectatorPort ) 
		{
			this.GetFunction<NativeUpdateSpectatorPortU>( this.Functions.UpdateSpectatorPort18 )( this.ObjectAddress, unSpectatorPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTagsS( IntPtr thisptr, string pchGameTags );
		public void SetGameTags( string pchGameTags ) 
		{
			this.GetFunction<NativeSetGameTagsS>( this.Functions.SetGameTags19 )( this.ObjectAddress, pchGameTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameDataS( IntPtr thisptr, string pchGameData );
		public void SetGameData( string pchGameData ) 
		{
			this.GetFunction<NativeSetGameDataS>( this.Functions.SetGameData20 )( this.ObjectAddress, pchGameData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCountOfSimultaneousGuestUsersPerSteamAccountI( IntPtr thisptr, Int32 nCount );
		public void SetCountOfSimultaneousGuestUsersPerSteamAccount( Int32 nCount ) 
		{
			this.GetFunction<NativeSetCountOfSimultaneousGuestUsersPerSteamAccountI>( this.Functions.SetCountOfSimultaneousGuestUsersPerSteamAccount21 )( this.ObjectAddress, nCount ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeEnumerateConnectedUsersIC( IntPtr thisptr, Int32 iterator, ref ConnectedUserInfo_t pConnectedUserInfo );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool EnumerateConnectedUsers( Int32 iterator, ref ConnectedUserInfo_t pConnectedUserInfo ) 
		{
			return this.GetFunction<NativeEnumerateConnectedUsersIC>( this.Functions.EnumerateConnectedUsers22 )( this.ObjectAddress, iterator, ref pConnectedUserInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameplayStats( IntPtr thisptr );
		public void GetGameplayStats(  ) 
		{
			this.GetFunction<NativeGetGameplayStats>( this.Functions.GetGameplayStats23 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetServerReputation( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 GetServerReputation(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetServerReputation>( this.Functions.GetServerReputation24 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestUserGroupStatusCC( IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDGroup );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestUserGroupStatus( CSteamID steamIDUser, CSteamID steamIDGroup ) 
		{
			return this.GetFunction<NativeRequestUserGroupStatusCC>( this.Functions.RequestUserGroupStatus25 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDGroup.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetPublicIP( IntPtr thisptr );
		public UInt32 GetPublicIP(  ) 
		{
			return this.GetFunction<NativeGetPublicIP>( this.Functions.GetPublicIP26 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAuthSessionTicketBIU( IntPtr thisptr, Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket );
		public UInt32 GetAuthSessionTicket( Byte[] pTicket, ref UInt32 pcbTicket ) 
		{
			return this.GetFunction<NativeGetAuthSessionTicketBIU>( this.Functions.GetAuthSessionTicket27 )( this.ObjectAddress, pTicket, (Int32) pTicket.Length, ref pcbTicket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EBeginAuthSessionResult NativeBeginAuthSessionBIC( IntPtr thisptr, Byte[] pAuthTicket, Int32 cbAuthTicket, UInt64 steamID );
		public EBeginAuthSessionResult BeginAuthSession( Byte[] pAuthTicket, CSteamID steamID ) 
		{
			return this.GetFunction<NativeBeginAuthSessionBIC>( this.Functions.BeginAuthSession28 )( this.ObjectAddress, pAuthTicket, (Int32) pAuthTicket.Length, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEndAuthSessionC( IntPtr thisptr, UInt64 steamID );
		public void EndAuthSession( CSteamID steamID ) 
		{
			this.GetFunction<NativeEndAuthSessionC>( this.Functions.EndAuthSession29 )( this.ObjectAddress, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelAuthTicketU( IntPtr thisptr, UInt32 hAuthTicket );
		public void CancelAuthTicket( UInt32 hAuthTicket ) 
		{
			this.GetFunction<NativeCancelAuthTicketU>( this.Functions.CancelAuthTicket30 )( this.ObjectAddress, hAuthTicket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeIsUserSubscribedAppInTicketCU( IntPtr thisptr, UInt64 steamID, UInt32 appID );
		public Int32 IsUserSubscribedAppInTicket( CSteamID steamID, UInt32 appID ) 
		{
			return this.GetFunction<NativeIsUserSubscribedAppInTicketCU>( this.Functions.IsUserSubscribedAppInTicket31 )( this.ObjectAddress, steamID.ConvertToUint64(), appID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GetUserAchievementStatusCS( IntPtr thisptr, UInt64 steamID, string pchAchievementName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GetUserAchievementStatus( CSteamID steamID, string pchAchievementName ) 
		{
			return this.GetFunction<Native_GetUserAchievementStatusCS>( this.Functions._GetUserAchievementStatus32 )( this.ObjectAddress, steamID.ConvertToUint64(), pchAchievementName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void Native_GSSetSpawnCountU( IntPtr thisptr, UInt32 ucSpawn );
		public void _GSSetSpawnCount( UInt32 ucSpawn ) 
		{
			this.GetFunction<Native_GSSetSpawnCountU>( this.Functions._GSSetSpawnCount33 )( this.ObjectAddress, ucSpawn ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSGetSteam2GetEncryptionKeyToSendToNewClientBUU( IntPtr thisptr, Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSGetSteam2GetEncryptionKeyToSendToNewClient( Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey ) 
		{
			return this.GetFunction<Native_GSGetSteam2GetEncryptionKeyToSendToNewClientBUU>( this.Functions._GSGetSteam2GetEncryptionKeyToSendToNewClient34 )( this.ObjectAddress, pvEncryptionKey, ref pcbEncryptionKey, cbMaxEncryptionKey ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendSteam2UserConnectUBUUUBU( IntPtr thisptr, UInt32 unUserID, Byte[] pvRawKey, UInt32 unKeyLen, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie, UInt32 cubCookie );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSSendSteam2UserConnect( UInt32 unUserID, Byte[] pvRawKey, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie ) 
		{
			return this.GetFunction<Native_GSSendSteam2UserConnectUBUUUBU>( this.Functions._GSSendSteam2UserConnect35 )( this.ObjectAddress, unUserID, pvRawKey, (UInt32) pvRawKey.Length, unIPPublic, usPort, pvCookie, (UInt32) pvCookie.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendSteam3UserConnectCUBU( IntPtr thisptr, UInt64 steamID, UInt32 unIPPublic, Byte[] pvCookie, UInt32 cubCookie );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSSendSteam3UserConnect( CSteamID steamID, UInt32 unIPPublic, Byte[] pvCookie ) 
		{
			return this.GetFunction<Native_GSSendSteam3UserConnectCUBU>( this.Functions._GSSendSteam3UserConnect36 )( this.ObjectAddress, steamID.ConvertToUint64(), unIPPublic, pvCookie, (UInt32) pvCookie.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendUserConnectUUUBU( IntPtr thisptr, UInt32 unUserID, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie, UInt32 cubCookie );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSSendUserConnect( UInt32 unUserID, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie ) 
		{
			return this.GetFunction<Native_GSSendUserConnectUUUBU>( this.Functions._GSSendUserConnect37 )( this.ObjectAddress, unUserID, unIPPublic, usPort, pvCookie, (UInt32) pvCookie.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSRemoveUserConnectU( IntPtr thisptr, UInt32 unUserID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSRemoveUserConnect( UInt32 unUserID ) 
		{
			return this.GetFunction<Native_GSRemoveUserConnectU>( this.Functions._GSRemoveUserConnect38 )( this.ObjectAddress, unUserID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSUpdateStatusIIISSS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSUpdateStatus( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName ) 
		{
			return this.GetFunction<Native_GSUpdateStatusIIISSS>( this.Functions._GSUpdateStatus39 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSCreateUnauthenticatedUserC( IntPtr thisptr, ref UInt64 pSteamID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSCreateUnauthenticatedUser( ref CSteamID pSteamID ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<Native_GSCreateUnauthenticatedUserC>( this.Functions._GSCreateUnauthenticatedUser40 )( this.ObjectAddress, ref s0 ); pSteamID = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendUserDisconnectCU( IntPtr thisptr, UInt64 arg0, UInt32 unUserID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool _GSSendUserDisconnect( CSteamID arg0, UInt32 unUserID ) 
		{
			return this.GetFunction<Native_GSSendUserDisconnectCU>( this.Functions._GSSendUserDisconnect41 )( this.ObjectAddress, arg0.ConvertToUint64(), unUserID ); 
		}
		
	};
}
