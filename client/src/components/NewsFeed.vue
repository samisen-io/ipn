<template>
  <div class="container">
   
      <img src="../assets/NewsList.png" class="Blogo" alt="Logo" />
   
    <div class="media-list">
      <div class="media" v-for="article in articles" :key="article.url">
        <div class="d-flex align-items-center">
          <div class="flex-shrink-0">
            <a v-bind:href="article.url" target="_blank">
              <img class="media-object" v-bind:src="article.urlToImage" />
            </a>
          </div>
          <div class="flex-grow-1 ms-3">
            <p>
              <a v-bind:href="article.url" target="_blank">{{
                article.title
              }}</a>
            </p>

            <h5>
              <i>By {{ article.author }}</i>
            </h5>

            <h5>{{ article.description }}</h5>
          </div>
        </div>
      </div>
    </div>
    <br />
    <br />
    <br />
  </div>
</template>

<script>
export default {
  name: "newslist",
  data() {
    return {
      articles: [],
    };
  },
  methods: {
    getDataFromFeed() {
      this.articles = [
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "GQ",
          title:
            "Bentley Continental GT Speed: Neues Luxus-Coupé schafft 335 km/h",
          description:
            "W12-Power, 659 PS, 335 km/h Topspeed: Der Bentley Continental GT Speed wird seinem Namen mehr als gerecht. Nie war das Luxus-Coupé schneller!",
          url: "https://www.gq-magazin.de/auto-technik/article/bentley-continental-gt-speed-2021-schnellstes-luxus-coupe",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/bentley-continental-gt-speed-luxus-auto-aufmjpg.jpg",
          publishedAt: "2021-03-24T12:37:04Z",
          content:
            "Performance-orientiert, ohne Abstriche bei Komfort und Luxus: Das verspricht der neue Bentley Continental GT Speed. Mit 659 PS, 900 Nm Drehmoment und sechs Liter Hubraum will das mittlerweile dritte … [+3438 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "GQ",
          title: "Apple Neuheiten: Was wir vor der ersten Keynote 2021 wissen!",
          description:
            "Bald soll es so weit sein: Bei der ersten Keynote 2021 präsentiert Apple Neues aus Cupertino. Auf diese Produkte dürfen wir uns freuen!",
          url: "https://www.gq-magazin.de/auto-technik/article/apple-neuheiten-2021-das-wissen-wir-vor-keynote",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/apple-neuheiten-event-erste-keynote-2021-technik-aufmjpg.jpg",
          publishedAt: "2021-03-23T17:09:52Z",
          content:
            "Auf eines ist im Frühjahr immer Verlass: Apple präsentiert seine (ersten) neuen Produkte. Glauben wir den jüngsten Gerüchten, wird das auch 2021 so sein und dieses Jahr sogar wieder live aus Cupertin… [+2936 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "GQ",
          title:
            "BMW i4: Alles zu Design, Leistung und Verkaufsstart des E-Coupés",
          description:
            "Der BMW i4 lässt sein Tarnkleid fallen: Endlich wissen wir, wie das vollelektrische Coupé aussieht – und auch zur Performance gibt es News.",
          url: "https://www.gq-magazin.de/auto-technik/article/bmw-i4-e-coupe-erste-bilder-design-leistung-verkaufsstart",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/bmw-i4-erste-bilder-e-coupe-auto-aufmjpg.jpg",
          publishedAt: "2021-03-19T21:23:26Z",
          content:
            "Optisch wagt der Münchner Autobauer beim BMW i4 keine Experimente. Das neue E-Auto, das noch dieses Jahr auf den Markt kommen soll, erinnert doch stark an das 4er Gran Coupé mit einem kleinen aber fe… [+2876 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "GQ",
          title:
            "Amazon Echo Show 10: So wird der Smart Speaker zur Videokamera",
          description:
            "Der neue Amazon Echo Show 10 kommt endlich nach Deutschland – mit einer brandneuen Funktion: Der Smart Speaker dient auch als Überwachungskamera!",
          url: "https://www.gq-magazin.de/auto-technik/article/amazon-echo-show-10-smart-speaker-ueberwachungskamera",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/amazon-echo-show-10-smart-speaker-videokamera-technik-aufmjpg.jpg",
          publishedAt: "2021-03-18T16:14:37Z",
          content:
            '"Entwickelt, um Ihren Bewegungen zu folgen." Was bislang nach einem Werbespruch für Videokameras klang, ist das Haupt-Verkaufsargument für den neuen Amazon Echo Show 10. In der jüngsten Version hat d… [+3026 chars]',
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "Benedikt Sauer",
          title:
            "Samsung: Neue Smartphones bieten Oberklasse-Features für jeden",
          description:
            "Mit der Enthüllung des Galaxy A52 und A72 zeigt Samsung, dass Smartphones mit Oberklasse-Features auch zum attraktiven Preis zu haben sind.",
          url: "https://www.gq-magazin.de/auto-technik/article/samsung-galaxy-a-serie-mittelklasse-smartphones-mit-oberklasse-features",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/samsung-galaxy-a52-a72-neue-smartphones-technik-aufmjpg.jpg",
          publishedAt: "2021-03-18T07:30:00Z",
          content:
            "Wir erinnern uns: Im Januar stellte Samsung das Galaxy A32 5G vor und gab damit den Startschuss für die neue A-Serie 2021. Der Nachfolger des Galaxy A31 erfreute die Fachpresse mit 5G-Datentransfer, … [+3871 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "Ricardo Vizcaino",
          title:
            "Audi Q4 e-tron: Blick in den Innenraum – noch vor Weltpremiere!",
          description:
            "Zumindest ein Geheimnis zum neuen Audi Q4 e-tron ist schon jetzt gelüftet: So sieht es im Innenraum des elektrischen Kompakt-SUV aus.",
          url: "https://www.gq-magazin.de/auto-technik/article/audi-q4-e-tron-elektrischer-kompakt-suv-innenraum",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/audi-q4-e-tron-vorserie-auto-aufmjpg.jpg",
          publishedAt: "2021-03-09T09:00:00Z",
          content:
            "Ein separater Pressetermin nur für die Neuerungen im Innenraum? Braucht's das? Ja! Im Inneren des Audi Q4 e-tron, der Mitte April der Weltöffentlichkeit präsentiert wird, ist nämlich so einiges ander… [+7848 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "Ralf Bernert",
          title:
            "Porsche Taycan Cross Turismo: Der E-Porsche mit Offroad-Genen",
          description:
            "So kennen wir den Taycan: E-Antrieb, E-Beschleunigung und E-Motion. Mit der Modellvariante Porsche Taycan Cross Turismo kommen neue Skills dazu.",
          url: "https://www.gq-magazin.de/auto-technik/article/porsche-taycan-cross-turismo-e-sportwagen-mit-offroad-kompetenz",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/porsche-taycan-cross-turismo-e-auto-neuheit-aufmjpg.jpg",
          publishedAt: "2021-03-06T08:00:00Z",
          content:
            'Autohersteller nutzen das Wort "cross" immer dann, wenn etwas überbrückt oder Dinge miteinander verbunden werden sollen so auch beim neuen Porsche Taycan Cross Turismo. Man könnte auch "Brücke" schre… [+4330 chars]',
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "Ralf Bernert",
          title: "Fahrbericht Audi RS e-tron GT: Das kann der Audi-Porsche",
          description:
            "Der schicke Bruder des ersten e-tron ist ein GT im besten Sinne – und als RS-Variante noch dynamischer. Wir haben den Audi RS e-tron GT getestet.",
          url: "https://www.gq-magazin.de/auto-technik/article/audi-rs-e-tron-gt-im-test-e-auto-fahrbericht",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/E-TronGTAufmacherjpg.jpg",
          publishedAt: "2021-03-03T20:01:15Z",
          content:
            "Na klar, der Audi RS e-tron GT ist schnell, blitzschnell sogar. Logisch, schließlich liefern die beiden E-Motoren mal eben insgesamt 598 Pferdestärken. Schlägt der Vorschlaghammer namens Boost zu, si… [+5714 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "GQ",
          title: "Volvo C40 Recharge: Dieses E-SUV schreit nach Sportlichkeit",
          description:
            "Volvo setzt auf emissionsfreies Fahren: Mit dem vollelektrischen C40 Recharge präsentiert der schwedische Automobilhersteller sein zweites E-SUV.",
          url: "https://www.gq-magazin.de/auto-technik/article/volvo-c40-recharge-zweites-e-suv-feiert-premiere",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/volvo-c40-recharge-e-auto-neuheit-aufmjpg.jpg",
          publishedAt: "2021-03-03T16:40:18Z",
          content:
            "Im Oktober 2019 stellte Volvo mit dem XC40 Recharge sein erstes Elektroauto vor nun folgt mit dem Volvo C40 Recharge bereits das zweite vollelektrische Modell. Dabei steht das neue E-SUV stellvertret… [+3163 chars]",
        },
        {
          source: { id: "wired-de", name: "Wired.de" },
          author: "Felix J. Strohbach",
          title:
            "Pininfarina Battista E-Hypercar: Stärker als Bugatti, teurer als Bentley",
          description:
            "Exklusiver kann ein Hypercar nicht sein – und das ohne Verbrennungsmotor. Der Pininfarina Battista ist ein E-Sportler mit GT-Komfort.",
          url: "https://www.gq-magazin.de/auto-technik/article/pininfarina-battista-elektrisches-hypercar-leistung-preis-reichweite",
          urlToImage:
            "https://res.cloudinary.com/wired-de/image/upload/t_teaser_square/v1/0/pininfarina-battista-elektrischer-supersportwagen-hypercar-auto-aufmjpg.jpg",
          publishedAt: "2021-03-02T11:33:54Z",
          content:
            "13 Zentimeter liegen beim Pininfarina Battista zwischen Pedal und Bodenblech. Sobald der Fahrer sein Bein durchstreckt, entfesselt er 1.900 PS elektrische Power und in wenigen Sekunden katapultiert i… [+4480 chars]",
        },
      ];
    },
  },
  created() {
    this.getDataFromFeed();
  },
};
</script>
<style>
.Blogo{
  display: block;
  margin-left: auto;
  margin-right: auto;
  margin-bottom: 20px;
  margin-top: 10px;
  
}
.media-object {
  width: 128px;
  padding: 10px;
}

.media {
  border-top: 1px solid lightgray;
  padding-top: 20px;
  text-align: left;
}

.media .glyphicon {
  color: #ccc;
}
</style>