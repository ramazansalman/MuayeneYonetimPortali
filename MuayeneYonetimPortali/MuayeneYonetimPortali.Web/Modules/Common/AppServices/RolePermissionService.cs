using MuayeneYonetimPortali.Administration;

namespace MuayeneYonetimPortali.AppServices;

public class RolePermissionService(ITwoLevelCache cache, ISqlConnections sqlConnections, ITypeSource typeSource)
    : BaseRolePermissionService<RolePermissionRow>(cache, sqlConnections, typeSource)
{
}