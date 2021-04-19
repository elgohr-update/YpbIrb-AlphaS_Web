﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AlphaS_Web.Models
{

    public class Participant
    {
        [BsonId]
        [JsonIgnore]
        public ObjectId _id { get; set; }

        [BsonElement("Participant_Id")]
        [JsonPropertyName("Participant_Id")]
        public int ID { get; set; }

        [JsonPropertyName("Birth_Date")]
        [BsonElement("Birth_Date")]
        public DateTime Birth_Date { get; set; }

        [BsonElement("Gender")]
        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [BsonElement("Nationality")]
        [JsonPropertyName("Nationality")]
        public string Nationality { get; set; }

        [BsonElement("Additional_Info")]
        [JsonPropertyName("Additional_Info")]
        public string AdditionalInfo { get; set; }



        public Participant(Participant _participant)
        {
            ID = _participant.ID;
            Birth_Date = _participant.Birth_Date;
            Gender = _participant.Gender;
            Nationality = _participant.Nationality;
            AdditionalInfo = _participant.AdditionalInfo;
        }

        public Participant(int id, DateTime birth_Date, string gender, string nationality, string addtitionalInfo)
        {
            ID = id;
            Birth_Date = birth_Date;
            Gender = gender;
            Nationality = nationality;
            AdditionalInfo = addtitionalInfo;
        }
    }
}
