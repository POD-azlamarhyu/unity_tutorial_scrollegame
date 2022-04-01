#include "Source/WinApi/Baselib_Thread_WinApi.inl.h"

namespace WinApi
{
namespace detail
{
    BASELIB_INLINE_IMPL void Thread_SetName(Baselib_Thread* thread, const char* name)
    {
        SetThreadDescription(thread->handle, WinApi_StringConversions_UTF8ToUTF16(name).c_str());
    }
}
}
