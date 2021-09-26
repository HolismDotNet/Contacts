using System;
using Holism.Contacts.DataAccess;
using Holism.Contacts.Models;
using Holism.Business;
using Holism.DataAccess;
using Holism.Infra;

namespace Holism.Contacts.Business
{
    public class ProfileBusiness : Business<Profile, Profile>
    {
        protected override Repository<Profile> WriteRepository =>
            Repository.Profile;

        protected override ReadRepository<Profile> ReadRepository =>
            Repository.Profile;
    }
}
