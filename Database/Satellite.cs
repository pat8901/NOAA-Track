/*
    NOAA-Track - Interactive interface for displaying various NOAA API data
    Copyright (C) 2024 Patrick O'Brien-Seitz

    NOAA-Track is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    NOAA-Track is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

// Creates the model for this app. A model is a class that represents data that the app manages.
namespace NOAA_Track.Database
{
    public class Satellite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}