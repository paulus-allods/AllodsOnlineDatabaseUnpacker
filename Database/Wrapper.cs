using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Database
{
    [PublicAPI]
    internal static class Wrapper
    {
        [DllImport("Main")]
        public static extern bool InitGameDataSystem([MarshalAs(UnmanagedType.LPUTF8Str)] string dataPath,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string localizationExtension,
            [MarshalAs(UnmanagedType.I1)] bool buildBinaries, [MarshalAs(UnmanagedType.I1)] bool buildTextPack,
            [MarshalAs(UnmanagedType.I1)] bool loadBinaries, [MarshalAs(UnmanagedType.I1)] bool buildHash);

        [DllImport("Main")]
        public static extern bool InitEditorDataSystem([MarshalAs(UnmanagedType.LPUTF8Str)] string dataPath,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string localizationExtension, [MarshalAs(UnmanagedType.I1)] bool noRcs,
            [MarshalAs(UnmanagedType.LPUTF8Str)] string rcsConfigFile);

        [DllImport("libdb", EntryPoint = "?GetMainDatabase@NDb@@YAPAVCBasicDatabase@1@XZ",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetMainDatabase();

        [DllImport("libdb", EntryPoint = "CSharp_GetMainDatabase")]
        internal static extern IntPtr GetMainDatabase_static();

        [DllImport("libdb", EntryPoint = "CSharp_Database_GetDBIDByName")]
        public static extern IntPtr GetDBIDByName(HandleRef jarg1, string jarg2);

        [DllImport("libdb", EntryPoint = "?GetObject@CGameDatabase@NDb@@UAEPAVCResource@2@ABVDBID@@@Z",
            CallingConvention = CallingConvention.ThisCall)]
        public static extern IntPtr GetObject(IntPtr database, IntPtr dbid);

        [DllImport("libdb", EntryPoint = "?DoesObjectExist@CGameDatabase@NDb@@EAE_NABVDBID@@@Z",
            CallingConvention = CallingConvention.ThisCall)]
        public static extern bool DoesObjectExist(IntPtr database, IntPtr dbid);

        [DllImport("libdb", EntryPoint = "CSharp_Database_GetObjectsList")]
        internal static extern string GetObjectsList(HandleRef jarg1, string jarg2);

        [DllImport("libdb", EntryPoint = "CSharp_Database_GetClassesList")]
        internal static extern string Database_GetClassesList(HandleRef jarg1);

        [DllImport("libdb", EntryPoint = "CSharp_Database_GetClassTypeNameByFile")]
        internal static extern string GetClassTypeNameByFile(HandleRef jarg1, string jarg2);
    }
}