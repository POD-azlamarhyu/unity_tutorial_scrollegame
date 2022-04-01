#pragma once

// These affect <windows.h> behavior; define them here so that no matter how/if later windows.h is included, it will get consistent result.
#ifndef WIN32_LEAN_AND_MEAN
    #define WIN32_LEAN_AND_MEAN
#endif
#ifndef NOMINMAX
    #define NOMINMAX 1
#endif

#ifndef EXPORTED_SYMBOL
    #define EXPORTED_SYMBOL __declspec(dllexport)
#endif
#ifndef IMPORTED_SYMBOL
    #define IMPORTED_SYMBOL __declspec(dllimport)
#endif

#ifndef PLATFORM_FUTEX_NATIVE_SUPPORT
    #define PLATFORM_FUTEX_NATIVE_SUPPORT 1
#endif
