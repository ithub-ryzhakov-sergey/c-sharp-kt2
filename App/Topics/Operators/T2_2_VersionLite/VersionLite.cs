// Задача: реализовать сравнение версий по лексикографическому порядку: (Major, Minor, Patch).
// Требования:
// - Реализовать IComparable<VersionLite> и операторы <, >, <=, >=.
// - Сравнение: сначала Major, затем Minor, затем Patch.

// namespace App.Topics.Operators.T2_2_VersionLite;

// public class VersionLite : IComparable<VersionLite>
// {
//     public int Major { get; }
//     public int Minor { get; }
//     public int Patch { get; }
//     public VersionLite(int major, int minor, int patch)
//     {
//         if (major <0 || minor < 0 || patch < 0) {
//             throw new ArgumentOutOfRangeException();
//         }
//         this.Major = major;
//         this.Minor = minor;
//         this.Patch = patch;
//     }
//     public static bool operator <(VersionLite _versionLite, VersionLite __versionLite)
//     {
//         if (_versionLite.Major > __versionLite.Major)
//         {
//             return true;
//         }
//         else if (_versionLite.Minor > __versionLite.Minor)
//         {
//             return true;
//         }
//         else if (_versionLite.Patch > __versionLite.Patch)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     public static bool operator >(VersionLite _versionLite, VersionLite __versionLite)
//     {
//         if (_versionLite.Major < __versionLite.Major)
//         {
//             return true;
//         }
//         else if (_versionLite.Minor < __versionLite.Minor)
//         {
//             return true;
//         }
//         else if (_versionLite.Patch < __versionLite.Patch)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     public static bool operator <=(VersionLite _versionLite, VersionLite __versionLite)
//     {
//         if (_versionLite.Major >= __versionLite.Major)
//         {
//             return true;
//         }
//         else if (_versionLite.Minor >= __versionLite.Minor)
//         {
//             return true;
//         }
//         else if (_versionLite.Patch >= __versionLite.Patch)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     public static bool operator >=(VersionLite _versionLite, VersionLite __versionLite)
//     {
//         if (_versionLite.Major <= __versionLite.Major)
//         {
//             return true;
//         }
//         else if (_versionLite.Minor <= __versionLite.Minor)
//         {
//             return true;
//         }
//         else if (_versionLite.Patch <= __versionLite.Patch)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     int IComparable<VersionLite>.CompareTo(VersionLite? other)
//     {
        // if (other == null) { return 1; }
        // if (this.Major > other.Major)
        // {
        //     return 1;
        // }
        // else if (this.Major == other.Major)
        // {
        //     return 0;
        // }
        // else
        // {
        //     if (this.Minor > other.Minor)
        // {
        //     return 1;
        // }
        // else if (this.Minor == other.Minor)
        // {
        //     return 0;
        // }
        // else
        // {
        //     if (this.Patch > other.Patch)
        // {
        //     return 1;
        // }
        // else if (this.Patch == other.Patch)
        // {
        //     return 0;
        // }
        // else
        // {
        //             return -1;
        // }
        // }
        // }
//         return 0;
//     }
// }
