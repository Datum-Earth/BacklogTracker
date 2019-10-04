using ASUS_GamesDB.POCOs.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASUS_GamesDB.POCOs
{
    public class Game
    {
        /// <summary>
        /// Reference ID for Age Ratings
        /// </summary>
        [JsonProperty("age_ratings")]
        public List<string> AgeRatingIds { get; set; }

        /// <summary>
        /// Rating based on external critic scores
        /// </summary>
        [JsonProperty("aggregated_rating")]
        public double AggregatedRating { get; set; }

        /// <summary>
        /// Number of external critic scores used in aggregate rating.
        /// </summary>
        [JsonProperty("aggregated_rating_count")]
        public int AggregatedRatingCount { get; set; }

        /// <summary>
        /// Array of Alternate Name IDs
        /// </summary>
        [JsonProperty("alternative_names")]
        public List<string> AlternativeNameIds { get; set; }

        /// <summary>
        /// Array of Artwork IDs for the game
        /// </summary>
        [JsonProperty("artworks")]
        public List<string> ArtworkIds { get; set; }

        /// <summary>
        /// If a bundle, these are the games inside of it
        /// </summary>
        [JsonProperty("bundles")]
        public List<string> BundleGameIds { get; set; }

        /// <summary>
        /// The category of the game. Whether it's the base game, and expansion, dlc, etc.
        /// </summary>
        [JsonProperty("category")]
        public Category Category { get; set; }

        /// <summary>
        /// Reference ID for the series the game belongs to
        /// </summary>
        [JsonProperty("collection")]
        public string CollectionId { get; set; }

        /// <summary>
        /// Reference ID for the cover art of the game
        /// </summary>
        [JsonProperty("cover")]
        public string CoverId { get; set; }

        /// <summary>
        /// UTS (Unix Time Stamp) Date the game was initially added to the IGDB database.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixTimeStampConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// DLCs for the game
        /// </summary>
        [JsonProperty("dlcs")]
        public List<string> DlcIds { get; set; }

        /// <summary>
        /// Expansions for the game
        /// </summary>
        [JsonProperty("expansions")]
        public List<string> ExpansionIds { get; set; }

        /// <summary>
        /// External IDs for the game on other game db services
        /// </summary>
        [JsonProperty("external_games")]
        public List<string> ExternalGameIds { get; set; }

        /// <summary>
        /// UTS (Unix Time stamp) Date the game was released
        /// </summary>
        [JsonProperty("first_release_date")]
        [JsonConverter(typeof(UnixTimeStampConverter))]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Number of people following the game on IGDB
        /// </summary>
        [JsonProperty("follows")]
        public int FollowCount { get; set; }

        /// <summary>
        /// Reference ID for the game's Franchise.
        /// </summary>
        [JsonProperty("franchise")]
        public string FranchiseId { get; set; }

        /// <summary>
        /// Other franchises the game belongs to.
        /// </summary>
        [JsonProperty("franchises")]
        public List<string> FranchiseIds { get; set; }

        /// <summary>
        /// Game engines the game uses.
        /// </summary>
        [JsonProperty("game_engines")]
        public List<string> GameEngineIds { get; set; }

        /// <summary>
        /// Modes of gameplay
        /// </summary>
        [JsonProperty("game_modes")]
        public List<string> GameModeIds { get; set; }

        /// <summary>
        /// Genres of the game
        /// </summary>
        [JsonProperty("genres")]
        public List<string> GenreIds { get; set; }

        /// <summary>
        /// Number of follows a game gets before release
        /// </summary>
        [JsonProperty("hypes")]
        public int HypeCount { get; set; }

        /// <summary>
        /// IGDB Id for the game.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Companies involved with the game.
        /// </summary>
        [JsonProperty("involved_companies")]
        public List<string> InvolvedCompanies { get; set; }

        /// <summary>
        /// Keywords associated with the game.
        /// </summary>
        [JsonProperty("keywords")]
        public List<string> KeywordIds { get; set; }

        /// <summary>
        /// Multplayer Modes for the game
        /// </summary>
        [JsonProperty("multiplayer_modes")]
        public List<string> MultiplayerModeIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// If the game is a dlc/expansion, this is the parent game Id
        /// </summary>
        [JsonProperty("parent_game")]
        public string ParentGameId { get; set; }

        /// <summary>
        /// Collection of platforms the game is available on
        /// </summary>
        [JsonProperty("platforms")]
        public List<string> PlatformIds { get; set; }

        /// <summary>
        /// Collection of player perspectives
        /// </summary>
        [JsonProperty("player_perspectives")]
        public List<string> PlayerPerspectiveIds { get; set; }

        /// <summary>
        /// The popularity score of the game.
        /// </summary>
        [JsonProperty("popularity")]
        public double PopularityScore { get; set; }

        /// <summary>
        /// Number of Pulse articles regarding the game.
        /// </summary>
        [JsonProperty("pulse_count")]
        public int PulseArticleCount { get; set; }

        /// <summary>
        /// Average IGDB user rating
        /// </summary>
        [JsonProperty("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Total number of IGDB user ratings
        /// </summary>
        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }

        /// <summary>
        /// Collection of release dates.
        /// </summary>
        [JsonProperty("release_dates")]
        public List<string> ReleaseDateIds { get; set; }

        /// <summary>
        /// Collection of screenshots for the game.
        /// </summary>
        [JsonProperty("screenshots")]
        public List<string> ScreenshotIds { get; set; }

        /// <summary>
        /// Collection of games similar to this game.
        /// </summary>
        [JsonProperty("similar_games")]
        public List<string> SimilarGameIds { get; set; }

        /// <summary>
        /// A url-safe, unique, lower-case version of the name.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Collection of standalone expansions for the game.
        /// </summary>
        [JsonProperty("standalone_expansions")]
        public List<string> StandaloneExpansionIds { get; set; }

        /// <summary>
        /// The status of the game's release.
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }

        /// <summary>
        /// A short description of the game's story.
        /// </summary>
        [JsonProperty("storyline")]
        public string StoryDescription { get; set; }

        /// <summary>
        /// A summary of the game.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Collection of related entities in the IGDB API
        /// </summary>
        [JsonProperty("tags")]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// Collection of themes for the game.
        /// </summary>
        [JsonProperty("themes")]
        public List<string> ThemeIds { get; set; }

        /// <summary>
        /// Reference ID for the time to beat for the game.
        /// </summary>
        [JsonProperty("time_to_beat")]
        public string TimeToBeatId { get; set; }

        /// <summary>
        /// Average rating based on both IGDB user and external critic scores
        /// </summary>
        [JsonProperty("total_rating")]
        public double TotalRating { get; set; }

        /// <summary>
        /// Total number of user and external critic scores
        /// </summary>
        [JsonProperty("total_rating_count")]
        public int TotalRatingCount { get; set; }

        /// <summary>
        /// UTS (Unix Time Stamp) representation of the last date the entry was updated in the IGDB database
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixTimeStampConverter))]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The website address (URL) of the item
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// If a version, this is the main game
        /// </summary>
        [JsonProperty("version_parent")]
        public string VersionParentId { get; set; }

        /// <summary>
        /// Title of this version (i.e. Gold Edition, Anniversary Edition, etc)
        /// </summary>
        [JsonProperty("version_title")]
        public string VersionTitle { get; set; }

        /// <summary>
        /// Collection of videos for the game.
        /// </summary>
        [JsonProperty("videos")]
        public List<string> VideoIds { get; set; }

        /// <summary>
        /// Collection of websites associated to the game.
        /// </summary>
        [JsonProperty("websites")]
        public List<string> WebsiteIds { get; set; }
    }
}
