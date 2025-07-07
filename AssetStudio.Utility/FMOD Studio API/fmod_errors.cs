/* =================================================================================================== */
/* FMOD Studio - Error string header file. Copyright (c), Firelight Technologies Pty, Ltd. 2004-2016.  */
/*                                                                                                     */
/* Use this header if you want to store or display a string version / english explanation of           */
/* the FMOD error codes.                                                                               */
/*                                                                                                     */
/* =================================================================================================== */

namespace FMOD
{
    public class Error
    {
        public static string String(FMOD.RESULT errcode)
        {
            switch (errcode)
            {
                case FMOD.RESULT.OK: return "没有错误。";
                case FMOD.RESULT.ERR_BADCOMMAND: return "尝试在不支持此功能的数据类型上调用函数（例如在流声音上调用Sound::lock）。";
                case FMOD.RESULT.ERR_CHANNEL_ALLOC: return "尝试分配通道时出错。";
                case FMOD.RESULT.ERR_CHANNEL_STOLEN: return "指定的通道已被复用，用于播放其他声音。";
                case FMOD.RESULT.ERR_DMA: return "DMA失败，有关更多信息，请查看调试输出。";
                case FMOD.RESULT.ERR_DSP_CONNECTION: return "DSP连接错误。连接可能导致循环依赖，或连接了缓冲区计数不兼容的DSP。";
                case FMOD.RESULT.ERR_DSP_DONTPROCESS: return "DSP处理查询回调返回的代码。告诉混音器不要调用处理回调，从而不消耗CPU，使用此选项优化DSP图形。";
                case FMOD.RESULT.ERR_DSP_FORMAT: return "DSP格式错误。DSP单元可能尝试以错误的格式连接到此网络，或者如果目标单元有指定的通道映射，矩阵可能设置了错误的大小。";
                case FMOD.RESULT.ERR_DSP_INUSE: return "DSP已在混音器的DSP网络中。在重新插入或释放之前，必须先将其移除。";
                case FMOD.RESULT.ERR_DSP_NOTFOUND: return "DSP连接错误。找不到指定的DSP单元。";
                case FMOD.RESULT.ERR_DSP_RESERVED: return "DSP操作错误。无法在此DSP上执行操作，因为它被系统保留。";
                case FMOD.RESULT.ERR_DSP_SILENCE: return "DSP处理查询回调返回的代码。告诉混音器读取操作将产生静音，因此进入空闲状态并不消耗CPU，使用此选项优化DSP图形。";
                case FMOD.RESULT.ERR_DSP_TYPE: return "无法在这种类型的DSP上执行此DSP操作。";
                case FMOD.RESULT.ERR_FILE_BAD: return "加载文件时出错。";
                case FMOD.RESULT.ERR_FILE_COULDNOTSEEK: return "无法执行查找操作，这是介质（如网络流）或文件格式的限制。";
                case FMOD.RESULT.ERR_FILE_DISKEJECTED: return "读取时介质被弹出。";
                case FMOD.RESULT.ERR_FILE_EOF: return "在尝试读取essential data时意外到达文件末尾（文件被截断?）。";
                case FMOD.RESULT.ERR_FILE_ENDOFDATA: return "在尝试读取数据时到达当前块的末尾。";
                case FMOD.RESULT.ERR_FILE_NOTFOUND: return "未找到文件。";
                case FMOD.RESULT.ERR_FORMAT: return "不支持的文件或音频格式。";
                case FMOD.RESULT.ERR_HEADER_MISMATCH: return "FMOD头文件与FMOD Studio 库或FMOD Low Level库之间存在版本不匹配。";
                case FMOD.RESULT.ERR_HTTP: return "发生HTTP错误。这是未在其他地方列出的HTTP错误的通用捕获。";
                case FMOD.RESULT.ERR_HTTP_ACCESS: return "指定的资源需要身份验证或被禁止访问。";
                case FMOD.RESULT.ERR_HTTP_PROXY_AUTH: return "访问指定资源需要代理身份验证。";
                case FMOD.RESULT.ERR_HTTP_SERVER_ERROR: return "发生HTTP服务器错误。";
                case FMOD.RESULT.ERR_HTTP_TIMEOUT: return "HTTP请求超时。";
                case FMOD.RESULT.ERR_INITIALIZATION: return "FMOD未正确初始化，不支持此功能。";
                case FMOD.RESULT.ERR_INITIALIZED: return "在System::init之后无法调用此命令。";
                case FMOD.RESULT.ERR_INTERNAL: return "发生了不应该发生的错误。请联系技术支持。";
                case FMOD.RESULT.ERR_INVALID_FLOAT: return "传入的值是NaN、Inf或非规范化浮点数。";
                case FMOD.RESULT.ERR_INVALID_HANDLE: return "使用了无效的对象句柄。";
                case FMOD.RESULT.ERR_INVALID_PARAM: return "向此函数传递了无效参数。";
                case FMOD.RESULT.ERR_INVALID_POSITION: return "向此函数传递了无效的查找位置。";
                case FMOD.RESULT.ERR_INVALID_SPEAKER: return "基于当前扬声器模式，向此函数传递了无效的扬声器。";
                case FMOD.RESULT.ERR_INVALID_SYNCPOINT: return "同步点不是来自此声音句柄。";
                case FMOD.RESULT.ERR_INVALID_THREAD: return "尝试在不支持的线程上调用函数。";
                case FMOD.RESULT.ERR_INVALID_VECTOR: return "传入的向量不是单位长度或不垂直。";
                case FMOD.RESULT.ERR_MAXAUDIBLE: return "达到此声音的声音组的最大可听播放计数。";
                case FMOD.RESULT.ERR_MEMORY: return "内存或资源不足。";
                case FMOD.RESULT.ERR_MEMORY_CANTPOINT: return "无法在非PCM源数据上使用FMOD_OPENMEMORY_POINT，或者如果使用了FMOD_CREATECOMPRESSEDSAMPLE，则无法在非 mp3/xma/adpcm 数据上使用。";
                case FMOD.RESULT.ERR_NEEDS3D: return "尝试在2D声音上调用本应针对3D声音的命令。";
                case FMOD.RESULT.ERR_NEEDSHARDWARE: return "尝试使用需要硬件支持的功能。";
                case FMOD.RESULT.ERR_NET_CONNECT: return "无法连接到指定的主机。";
                case FMOD.RESULT.ERR_NET_SOCKET_ERROR: return "发生套接字错误。这是未在其他地方列出的套接字相关错误的通用捕获。";
                case FMOD.RESULT.ERR_NET_URL: return "无法解析指定的URL。";
                case FMOD.RESULT.ERR_NET_WOULD_BLOCK: return "非阻塞套接字上的操作无法立即完成。";
                case FMOD.RESULT.ERR_NOTREADY: return "无法执行操作，因为指定的声音/DSP连接尚未准备好。";
                case FMOD.RESULT.ERR_OUTPUT_ALLOCATED: return "初始化输出设备时出错，更具体地说，输出设备已在使用中，无法重复使用。";
                case FMOD.RESULT.ERR_OUTPUT_CREATEBUFFER: return "创建硬件声音缓冲区时出错。";
                case FMOD.RESULT.ERR_OUTPUT_DRIVERCALL: return "调用标准声卡驱动程序失败，这可能意味着驱动程序有错误，或者资源丢失或耗尽。";
                case FMOD.RESULT.ERR_OUTPUT_FORMAT: return "声卡不支持指定的格式。";
                case FMOD.RESULT.ERR_OUTPUT_INIT: return "初始化输出设备时出错。";
                case FMOD.RESULT.ERR_OUTPUT_NODRIVERS: return "输出设备没有安装驱动程序。如果是预初始化，将选择FMOD_OUTPUT_NOSOUND 作为输出模式。如果是后初始化，函数将失败。";
                case FMOD.RESULT.ERR_PLUGIN: return "插件返回了未指定的错误。";
                case FMOD.RESULT.ERR_PLUGIN_MISSING: return "请求的输出、DSP单元类型或编解码器不可用。";
                case FMOD.RESULT.ERR_PLUGIN_RESOURCE: return "插件所需的资源找不到（例如MIDI播放所需的DLS文件）。";
                case FMOD.RESULT.ERR_PLUGIN_VERSION: return "插件是使用不支持的SDK版本构建的。";
                case FMOD.RESULT.ERR_RECORD: return "初始化录音设备时出错。";
                case FMOD.RESULT.ERR_REVERB_CHANNELGROUP: return "无法在此通道上设置混响属性，因为父通道组拥有混响连接。";
                case FMOD.RESULT.ERR_REVERB_INSTANCE: return "无法设置FMOD_REVERB_PROPERTIES 中指定的实例。最可能的原因是实例编号无效或混响不存在。";
                case FMOD.RESULT.ERR_SUBSOUNDS: return "发生错误是因为引用的声音包含子声音（而此时不应该包含），或者它不包含子声音（而此时应该包含）。此操作也可能无法在父声音上执行。";
                case FMOD.RESULT.ERR_SUBSOUND_ALLOCATED: return "此子声音已被另一个声音使用，一个子声音不能有多个父声音。请先清空其他父声音的条目。";
                case FMOD.RESULT.ERR_SUBSOUND_CANTMOVE: return "共享子声音不能从其父流中替换或移动，例如当父流是FSB文件时。";
                case FMOD.RESULT.ERR_TAGNOTFOUND: return "找不到指定的标签，或根本没有标签。";
                case FMOD.RESULT.ERR_TOOMANYCHANNELS: return "创建的声音超过了允许的输入通道数。可以使用System::setSoftwareFormat中的 'maxinputchannels' 参数增加此限制。";
                case FMOD.RESULT.ERR_TRUNCATED: return "检索到的字符串太长，无法放入提供的缓冲区，已被截断。";
                case FMOD.RESULT.ERR_UNIMPLEMENTED: return "FMOD中某些功能未实现（但应该实现）！请联系技术支持！";
                case FMOD.RESULT.ERR_UNINITIALIZED: return "此命令失败，因为尚未调用System::init或System::setDriver。";
                case FMOD.RESULT.ERR_UNSUPPORTED: return "发出的命令不被此对象支持。可能是插件缺少某些回调函数。";
                case FMOD.RESULT.ERR_VERSION: return "不支持此文件格式的版本号。";
                case FMOD.RESULT.ERR_EVENT_ALREADY_LOADED: return "指定的音轨库已加载。";
                case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_BUSY: return "实时更新连接失败，因为游戏已连接。";
                case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_MISMATCH: return "实时更新连接失败，因为游戏数据与工具不同步。";
                case FMOD.RESULT.ERR_EVENT_LIVEUPDATE_TIMEOUT: return "实时更新连接超时。";
                case FMOD.RESULT.ERR_EVENT_NOTFOUND: return "找不到请求的事件、总线或VCA。";
                case FMOD.RESULT.ERR_STUDIO_UNINITIALIZED: return "Studio::System对象尚未初始化。";
                case FMOD.RESULT.ERR_STUDIO_NOT_LOADED: return "指定的资源未加载，因此无法卸载。";
                case FMOD.RESULT.ERR_INVALID_STRING: return "向此函数传递了无效字符串。";
                case FMOD.RESULT.ERR_ALREADY_LOCKED: return "指定的资源已被锁定。";
                case FMOD.RESULT.ERR_NOT_LOCKED: return "指定的资源未被锁定，因此无法解锁。";
                case FMOD.RESULT.ERR_RECORD_DISCONNECTED: return "指定的录音驱动程序已断开连接。";
                case FMOD.RESULT.ERR_TOOMANYSAMPLES: return "提供的长度超过了允许的限制。";
                default: return "未知错误。";
            }
        }
    }
}
