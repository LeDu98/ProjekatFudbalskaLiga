﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{   [Serializable]
    public class Tim:IEntity
    {
        [Browsable(false)]
        public int TimID { get; set; }
        [Browsable(false)]
        public int Pozicija { get; set; }
        public string Naziv { get; set; }
        public string Grad { get; set; }
        public string BojaKluba { get; set; }
        [Browsable(false)]
        public int OdigraneUtakmice { get; set; }
        [Browsable(false)]
        public int Pobede { get; set; }
        [Browsable(false)]
        public int Neresene { get; set; }
        [Browsable(false)]
        public int Porazi { get; set; }
        [Browsable(false)]
        public int Bodovi { get; set; }
        [Browsable(false)]
        public List<Igrac> ListaIgraca { get; set; }
        [Browsable(false)]
        public string Tabela => "Tim";
        [Browsable(false)]
        public string InsertVrednosti => $"{TimID},'{Naziv}','{Grad}','{BojaKluba}',{Pobede},{Neresene},{Porazi},{Bodovi}";
        [Browsable(false)]
        public object JoinTabele => "";
        [Browsable(false)]
        public object UpdateVrednosti => $"Naziv = '{Naziv}', Grad = '{Grad}', BojaKluba = '{BojaKluba}', Pobede = {Pobede}, Neresene = {Neresene}, Porazi = {Porazi}, Bodovi={Bodovi}";
        [Browsable(false)]
        public object Uslov => $"TimID = {TimID}";
        [Browsable(false)]
        public object OrderBy => $"Naziv";
        [Browsable(false)]
        public string IdName => "TimID";

        public IEntity VratiEntity(SqlDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> VratiListu(SqlDataReader citac)
        {
            List<IEntity> result = new List<IEntity>();
            int x = 1;
            while (citac.Read())
            {
                result.Add(new Tim()
                {
                    TimID = (int)citac["TimID"],
                    Pozicija=x++,
                    Naziv = (string)citac["Naziv"],
                    Grad = (string)citac["Grad"],
                    BojaKluba = (string)citac["BojaKluba"],
                    Pobede = (int)citac["Pobede"],
                    Neresene = (int)citac["neresene"],
                    Porazi = (int)citac["porazi"],
                    OdigraneUtakmice=Pobede+Neresene+Porazi,
                    Bodovi=(int)citac["bodovi"],

                    
                });
            }
            return result;
        }
    }
}