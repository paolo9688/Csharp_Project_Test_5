Console.WriteLine("Inserire il proprio ruolo:");

String ruolo = "";

// ciclo while che continua in loop fintantochè la scelta del ruolo non ricade
// in uno dei tre indicati nella classe statica Ruolo:
while (ruolo != Ruolo.AMMINISTRATORE && ruolo != Ruolo.MANAGER && ruolo != Ruolo.UTENTE)
{
    // leggo la stringa immessa dall'utente:
    String scelta = Console.ReadLine().Trim().ToLower();

    // se la stringa inserit è vuota o nulla, viene sostituita dal valore "ruolo non valido":
    if (scelta == null || scelta == "")
    {
        ruolo = "ruolo non valido";
    }
    else
    {
        ruolo = scelta;
    }

    // se la stringa non corrisponde ad un valore valido, il loop si ripete:
    if (ruolo != Ruolo.AMMINISTRATORE && ruolo != Ruolo.MANAGER && ruolo != Ruolo.UTENTE)
    {
        Console.WriteLine("Prego inserire un ruolo valido:");
    }
}

// viene dichiarato il ruolo inserito:
Console.WriteLine("Il tuo ruolo è: " + ruolo);