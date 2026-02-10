using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models;

public interface ISearchable
{
    bool Matches(string searchTerm);
}
