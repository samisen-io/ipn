<template>
  <div class="container">
   
      <img src="../assets/IPNLogo.png" class="Blogo" alt="Logo" />
   
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
            "Monkeys attack Tourist in Badrachalam Temple",
          description:
            "Monkeys attacked and injured a trourist making a visit to the temple.",
          url: "",
          urlToImage:
            "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBYWFRgWFhUZGBgaHB4eGhwaHBwaHh4dHB4eHh4fIRocJC4lHh4tHxwaJzomKy8xNTU1HCQ7QDszPy40NTEBDAwMEA8QGBISGDEdGB00MTQxNDQxNDQ0NDQxMTQxMTQxMTQ0MTQxNDQ0NTExNDExNDQxMTQ/NDQ0MTE/MTExMf/AABEIAKgBLAMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAAAAgMEBQYBCAf/xABAEAABAwIFAgMFBQcDAwUBAAABAhEhADEDBBJBUWFxIoGRBTKhsfAGE8HR4QcUI0JSsvE0YpIkcnMzY4KDohX/xAAYAQEBAQEBAAAAAAAAAAAAAAAAAQIEA//EAB4RAQEBAQEAAQUAAAAAAAAAAAABEQIxIQMEE0FR/9oADAMBAAIRAxEAPwD4zRRVp9mkg5zLAhwcfCBB3daYoKuivQeZygKW0IA6aWFnEifMmmcPCQkEQX4DgDeSKD4FRXonDw0LQCUoSx94pSXhpD0wMrh+JKU+INOlAYcgXag8+0V9/wAvlkJc6EqD7gN+FO/u+CRCAP8AgxfgW5oPPdFehcPDRvYOw0gu97t1gCo6AhJ9xJPJSkvxcx6UHwKivvn3aGcIAJdyAJD2kCpKUIU50IILOyUluwDUHnqivQaMigoUQhLPCgI7O3HemkYSUsNKD4WYs09d+XtQfAaK9CJwkXQhAYSrSFCR9bU6lCRGlJuSSkCDIcM1hQedqK9FjDQrxFI1N/Q0BtmfS/50pWElIGpKWIkhKdX/AGi8OBYUHnKivR5yCAzDDDMS6dW8bAn8zUfGKFDwpQTcnSnoLc0HniivQ2BgI0sgBnuEWaZJhpbzoXhpUsn7tLC/hSAdzPN7UHnmivRycgjSfAkAySUgNEMW+mqMMojSFJQlRL3EhIdvzmz0HnqivRmFl06ZQhuyWBmo68DDjwJPiAgD0AYPdvoUHnuivRuNkwANKEkgsAQmzGWNvU3qNmMoHLAGNwja7AGia890V6JOXQkAaQSRLgFjw0/Gl4mXSY0J1Bg+kcW+PxorznRXonDy6D4SEANJbjsmn0YaB/JaR4B8H4I48qJrzfRXo791SCVhAJh4D7CSAwBMUpWTRpBCANyAkP6GznihrzfRXonCwE30JHA0pBM7P5/Gsb+1JH/SoVoCf4yA4DP4MTfyoa+UUUUUUVZ/ZsPm8sLfx8P+9NVlWP2fb96y72++w3/5ig+6qxEuQBfncDgBhRBLskFnuWYbBrveaQpaGBALvcF43DAnv+VcCtPjAIuwJBJe3bz4qgVlVPAU4DkiRf5fGulBSkDxAuFFx121UrBxruyVc9Or3HTtT+lOkkuzODbzHxoGU6SplQC9mjh4t680tTiAssCw/Q35FJUsJchDvuAY5u81w5ggQkkFwFHjcDr3agZxSQoJTIAYh2Du7iJNJWRqDw/8rCeGP4U+EFTEEAWcxNm+ua6UMoyTwxI7ASXtQAWUsnS5O/T4VxGpXugnm228HaaQsBCmA2l79Xe/1FKWkAgkiYuzhoEDpfvQSkYakoOlQBhrfmHLd6j47KIU+pRLEiXJl2PPzruDg6gyXEn3mLkbOqw6mupXpBBVBhLEPzF0/KiOYuXLFOmzEqPIsI8t9qVgptBJb+pLaTdJYP6GuIWWcqZJg9S27SJ3FPYKCBCw0MYEj8qBJxFBbAp0i6T+e8cUyi+oBr2ZnfdzKuhpxIGr3gbjzuWb513FZRslhxDDnebR1opvWGU47bTMEH0vXVY5YajpS7yZYuJ08R0pCV+87AAAeHrbZw4+pp/DKZZZLg+HQ3xEvvUEUrUACCoHrAINpO0cfnTisU6XuQRwDZpJn16U/hLAOsMwBCVaTBMEMXn86UcEyANRPZMAEudwYNERQtbJGogHe3eRUj91VpLF53Im3EzMUxiliDLPGpRsdnP1enkZoqBGkJb+kOC3BFmbagME6W1JHiBBEKPfT5HdrUvFzPiASCBdRfSwHH6TNcRglpWdREXd/UsD+dJRBPvFX9YuDv4fqwoFYiTLOUncHczJ6x62pQw3UR4WS6XYk2v4Xt607lMdT3Wo8EuI2MPSsxijV4QEuJKpkdpD2vQMYWFpkEuTwTxZLy9OhDK0BQHLxJ3L9rUKdmSSCGcyJ3honrTYQQCXkGe3m89ZoH1ICAbDiLnvDiflSFLdQPNieny3pnFXq94xw9vM0hCA0EqOw2JPTfigcx+T0fruLQfq1KW4SDqGlXvOoH107d6TgoJUYAItD96TijSnTra7gdb2+T0DygSU2bZkgvDuWsGrCftWxv8ApsNLMTipUQDwhYdtnB+dbdeaCBqMBoLSf16V8y/aJmVLww++KDzZKwJ33pSPnlFFFFFWX2cD5vLA2++w/wC9NVtWf2cS+bywmcbDtf300H2pekKh+WZ7G0Mx+FPYmMogmzbXi3u7bb0LwwtYvfZ3HQqdz5+tLWhIBToKiTEMoAWLwW61QrCQVh1AgmwJSk3guCwPpSsbNgoIV7yTG647Q270hGCFAJ1lKiCDt5OTtyX+NO5fIEE+FKik7sOIJMepagjpWoK3HLFjO8lvP4U5nCpSgglxsolJA9JHmacXKyyDIHulgDz1pClEkEpImUvB25kn5UCCkhUuoBkggvY8Az9XrmYLk7KGxg+YL/Rp1WKGfSQzgAkOxvEx51w5dZWgadKgIIIANyA7O5t9PQNjE1ABgLgkySwhgwD+b0pIFhvZyxBaYPwmufdwydXRZMvxx+NdRgrBAWIl7Jjl9/jQIKC5SAIIcSdrjb8q7j4LJHQw7n51NwUJ1MTKrMPr1pS8k5Z37fnUqyaYyzQ+96nYeQK5T8ZFcwfZ4TOoNu0ketWGUzWGghIXOwNR6fi6zxRjKBCiFOlrkSTL2JkedMqhQ0iAd9Icm1v5ehfvV77Y0rBI94VS4S9jVedhKldN5AEHzHZ4p/Aw03cuGiGvdmvyWp37t6YCClMtexMPDEm3+aIfwcQgsCEkmQ4E2Kgw6H1rqhqNgXuxEGwMSBPc1EwcwCCCXc2BJHqDPae1Opw3LBUtFhO1yB6NRHE4atTEpcC7MmNgL9bjalDNWUwLvpgFm3a525rowCEs4DbwR5NqDR613GShQQzBmkD3ju7y/peqG9DJdQLmx2A2cMeOaFITJK5UAwMkFn37mHNSMMAuSktaS7jdzx260jFAY2B6HTHA3J86gaQhLago8MSAU9jY/UUkhJUWlUMxMhobjf0p8okH3iQCNJsIEv8AQrisNgWSFEkkENw8nvQNowlABTkdA5+G9c02AJaFMQ8/X4U6VsCHLn3nJk8QWtxTKdQOkQroCW4vQOBCd/FuS0NwdulCcQaXbycN23e21JxENABYe8DqDdxD1wrMAy+w3G1tqB/DzZQp0oBaGaWPR6Zy2CnW5SdZdkgkJmxb3o6UwCUEliwsS4gmwOw6NzSfaXtIIw2QSFKswAgy9hQVft7OkqKEr1AE2gP+d7/pWF+2rfcJHC0738K9q0SnKo94msn9r8XUkN/KpI6e6qO9RWRoooqgq0+zR/6zLX/9fCtf302qrq0+zTfveWe33+E+386d9qD7xlsRIGkNqP8AMSAG4Zn9DTeMSC6kkOdiwi03NPZVM+6Qm5JATv2c0lalFTBRAS7aXI83uDVRzL4+slQIMXCSq8XVJNJxM1BDFWkOS7AbdGnYUlGpKiC7cCB5GSd/0pzNssggpENcR303PegaOZCgkOABB0zF7ySwpzUFnwqYH/8AQHw2+NCsPwgAEsfdnTu8kXMb0vMaYZCQHfwggPN9RO+9FLcBJUo3hgQT6AE2HNRxjaDqES6XBggxBvSUBKj/AEm3hZiZMl7M9LVipbQxJ/qbfiWPnNEcwC5kKcyD4Ujkinl5hGkeCSWcu4awDkx1qO+lUHWBJ4B+vlSMwyXSDBOrcs/U7TQO4HtBOpTjsaT7Q9r/AHeGlg5Wpn2Hf8qj4eWfepWWSyShaQpOzzWa6ft82z9onsbOrxMRSGUEkb/B+PypGW9g42sfeGAolweru19W1XGBjIQwToQBLuAB1NWiFamGlR1AnUGb85o6bPNvhleFqIILCxqoWhILpJLk22mKsfaOIUIJ86rPZyXQKOP6vz1bEvCSevrSl4bi1GXxhYq9acWlt45FqPNFUhSfELhi7CwuGPPNLwlqXqUAxYt4X8gozB2HWlnEI7U5giSQoAFnctbbzn41ZURMFC9KdSTBku7BrT/KO1TBhgIAALubPtuRAPek46AGDBxchL+TmNMX6UZkJ1RqKoeIAEQwsY70RJUSmS6nBBZj5lM1HVYRIcnmXuDIAfab00vGU86WMGRZiAAlVjf1pZMjSpuGBgRuzK/z1oE4mIoklixG7E9q4wJAA2DHUXDBrH6alFSiPfVM7SRwpO3R6aWsEMB53JI7tvzQJzOGxZb2ZhEX84b0roW6YM296Zt4QLUpA1EaSARYq8IBu5L3vNNqM6g6nPiADS+3+KJpz7ggMphLgyoE8ECPgaQnCADK8LhpBeLTv+FLAUDLgql3dpaQIefjtXClRUNJSCRcGPMbGikIzSEIJJESogbfra29ZLM5o4i1LMElxYsOPT5VY/aHNBwhJCgzKAGnxO9xcPv3qnwzLD9ahDqZJUtREEknc8/G9ZX7ZobCHJxAT/xXWkzGECoAeHSCCb6iSkt8Kzv2zT/BSY99Pf3V1VYmiiigKs/s4WzeWLP/ABsOP/mmqyrL7Of6vL7fxsP+9NB90UtRIdiSDAPu2/DpSQsvGlSW91InsW28zXMPCCi+rSb2Ad+QztXcwu2pkkA+7DPexrSHMBVilmtpkaZ63Hmac1aFSwfyckdRH4tTCEhKfFPFrmzd5rolla5MnUkp0taGc/pQLVmlJuAbwwjg6nYW45pzFx9Y5JYMJ6dwKjoxNbhhBd2QCX35+ddcCQq3BL+bpZuz1BxC/AQlmBkS3wny6U0gGSLC2l47ten/ALyCJLsyUkJA5JIDns9KwcQQoHUp21KPI/pew+NAytySS6ROxbU1i1Rcyo6dRLi1gDHTirTWp+SoMC+/0bVXe1yrRcMwEN+G0UVWZj2kRp0qMVL9n+1NZ0n3vreqJQlqZKylQaOtZalsbfBWELliQCR3aPjWNxPtTioWV6zBch/g1WmHnFKB/qYgdaxf/wDMOohbu896OmfUt5n9fVs57QGNgBaS4WEkN60z7Nx9IkVB9g5QpyyEnkkdqsMpgjxJJiq5+/TaMRK1uI4auYuZY3qPqShRB2qLncTxOLGs1lb5bHChUrLKeBf6kVn8oshQq4QrxXvZualVMXiTpEGSWH5UjFwtQLFhBlm8470IWo7l92aerGHrisV1FIDgOWsSYEitRikDEQksCFKeXkMwbkUan3AG0X40gX/Cm8QhJdttvEOkG9GANyIbdieHDX57DeqOICgVQlQHOv8AtctB2p1GAoFQG43exm4Db05906ywuz2F+LNtQhBBcFi93dgeyuSfSqGFJSHeRBtLjZ4LebRUnAmQNo8Lts1xNLxsMuCD4khiWJHAb4yaFYmpKQ7+8IYPNzyYHFBHU6laQCAA7qn/AB2+dV3tjNhKBPi2SJMHziPlVnjYgAUpTlgX0pF+gJAid6xftLNKxFuYhosWcP07VKkRvvCouqZeTbftUrDQUIUtVmcdn23eWA57Uxg4bmW0sXJ2PanQr7wlgyUh2fZNh3c+po0Ywl6kI6EnbctVB9sz/AT/AOQf2rq/CndwRe5/xzVN9s8uRlULa+KkDr4V/lQYKiiigKsvs4/73lmv99ht/wA01W1ZfZz/AFeW3/jYf96aD7viLh2BbcOPFxM0heFBKQ6mD+IwXkC533pzBy50yJEXj9flTeIdK9XhUTclITHADtafWtI4nLqeSx/3GdutuorqkEaR7xf/AHKHnv8AGnk4p8JHiUXizCdmcCm8Vpd3dy++2+w6UCDgovp3BLOw58J/Ol6AGGkpF5IkmH6WpSdKQfDHA/M/jTiFgEEX4/xQNIwUkFwzSJAfgWv5c07gKQFamdmgm3P8sgflUjCWkKVr7T12jo1M5hYBCkAgp87w5mRF+lQLxkJXdM9Hdr/zED0FVXt6MIsG8aeLMoB93t61aJXBsktJKQZF2JvvHWqb7SL/AIQTrKpcuwaIj86lWes6upZwwUCJqJlRqM1YFDVmNU3l1sOoqSvAwsYhesIXZQIu246ttUJT7U3h5cqJ6VV56xoU5xIAQgulIAeu5fFd6p8PDUKs8phmqnV06MuCS9VuawtKr1fFDjqKos4klRqVIdwTb5VZA6kODIqpwEFqn5azUVKwMYuDvYjmphw1JOoOxFzLWfeNrtUfI4HiatVksuUphm3epuJWbQhaXKkqL/zBmIB4M3Px9VpxgpOpKCSDJ/zc+VWPtrAIlJKeQO8txUAKMaUg2EqlrgsO9al1ktCC7CxLgNIeXD360tGGoEsWgWA/C17D41FVmFIAH9RfcsQwnrLt3p3CxUlkkXDkgP4n42oJGpsRJUkrcM23Qkg3mkKWFKL2BLESJ8yx22qOsFIDbkyEvyI1bRUfP+0lYSXJKiQySLfL6mlEH7SZ4SgAJO5D8QyXg3vzWXBD+g5+pp3HWVAlX8zz1Fx8RXMEBIK1bWfdVFkIzOaKEaEga/eUDE7CkZEq0OWBVfy2nvTeEkqUpZJ1MQHkFy4ipqZEmWEAWPH10qjuXwNapJ/QVC/aPghOUQzD+MkN/wDXiX6/Ra1aTK5XSlIYuq7B52Y1nf2m4YTlUQx+9TEP7uI5UQbk7VB8tooooCrL7OEDN5Ym332G/wDzFVtWf2bAObywNvvsN+2tNB9wKNSiQPCREEfBKmJjnanAwDpACUwdL+LkkqdqcIRqkHllF32sQ89DTa1giEaRItJL3DC9q0hlKWjWwu4g+u96fK3AAuLubj62pAB1QDG5duouG7ClIe8kvYBufrzoEo8QkAN1LdC3NOYWCpx4WDNqUw22/T4UgJdyAyd7yTy7P8KcTqDFUxGq3o/TtQBQFpEEM+4D337/ADp1CywulhMeYnytQtjGoaiHaRIFj8fXeuZdCiQkIU7cPPmC0b1BxGogl2MT8ma221Vn2kQfuwDcG3wf1q6w8fS2lLNa4Je579X+dQPtBqOGsEuwBsJbqD8aixk8mqamKW9U+WxnNW2GiHrMaoCadyytJPamMxjaBNMpzD1RPTiOat8ssNWWRjkKPD0/lvaMs9VGjx1kSDVRi4x1TVll8TUmombys0oaTjVOyq5mqZYarH2cSQD61FabK5WQsFhvVkv2loDXGxBrNYntUIGl9o46g9qpF+1CpRAJD7Pv+VSpmtyc0nEB3BFVoJLhwWcAdtgH5PNQvZOaeDFTMaSVSTDtZt+9wY4px7U6hKy0O4MmwJn8OtO4CyVHxWaxiYG8wwemlFLTBkQASYgmHIbam0Y6gd2vBaILlzZ33raJGIhKIcDhz1uXsW3rLe2M1rWWV4AWiw5M9n8qtftBnhoCRp1qBdTAMndjdzb1rL4iYfyi48vOokGDKmDmDtsJ2prP5hyEh/C7bzdzUnEXoQJZWIGHIT9CoGWQ0h255/OjaVhKBBct1Yyfw+VWns3CPvGag5bCKmiGj12q4xcVOGEggyWMEyeg6w1VD6swW0uQoPIJEHY7TWQ/aMonLJdw2MmJ3TiTNbBIFwCTqmCkDyVbseKy/wC01v3RDWOMi5D+5ifT9ag+V0UUUBVl9nUvmsuOcbD/AL01W1Z/Zr/V5b/z4X96aD7lmFQwAUWDqAG3f6710YLj+UbukS+7l/lRmVNKT7rBiq/Ozt0ekYRICioEC7M4B9Qa2hYwyA6VEA2ECN93mnypSEpmTsSLE8H5t50wFKWNZYhI4MflRoZgS9iYYdeIqBeMtQVsx4I44DNQtfclwASX9H2Z/WlIZLqEOxdLktxwOr8CnTihJcEFJFyJL7EQ+3rQJwUjUzmLSPmXjs1PpUC4aZe8iwboJvUdGL4DdVmJsBO+w6XroxrBSiXDBiOzkXA7/wCAkqQSxcAOA1n2DAWluk0nMYqF4SklU+Jhz09aZ+5K1pZY2Cdi43e3ztSs/hqw0nUkEm4vAsbkA9qivnmXQy24J+FXafdqmWllk8mp2XxSzG1Zi1D9qqcdqbyQsSa57ZVpGril5DESoBqqypeURHem1ZLSSbvUjCUxalYiqIk+zcyw0/UVZlYUms7hL01NRjUC8ygPTuSSZamVq1Bt6VllgWM7ipVii9o5slRSTY0ezwSX25pft/LeMq2UxpfsqxHNZGoyBBHB5qywsYEwbbyLX26N61Vez4qww8QgzCQYe/mD+FXmJ0nKwwXMk8GQARvtTCsNKAVlZKRdmYdrCPSkff6IcrBDBn0h5v5+VVft32tqwxhILbqaJix9fStfLF+VJmcZBWSVKKZYmZYxFg7dqRlkaiSoskSe3500A5I2Anv16vTmaWEoThhTksVkctbyo0iY6lLUpRImw4HFWOJlWGFyUOqLDUQ7fVqrkjfcW7Vd5HLLWHWTIG3uoT38/iaYJWRQyQ/uhykPubseSwepagFOD6vt5fV6eUhmTA2tbtwaXh4CrASrYPIE9v8ABoOISXOtRJIA1KIZXAVwf927TzWN/akGyqAHH8dMEMR4MT07VtFK8LXO/HesV+1Bb5VEN/GR/ZiCg+VUUUUBVl9nv9Vlnt99h/3pqtqz+zgJzeWAZ/vsNnt76b9KD7diKAdOoc/gAZYmkoQXAJAJuHYF/P5UoggnUzHi3qdu1Ly6UwAoTcOqB2AraFpWQPErwG4t0g9vnScfTBDv1CrbMduGim8wsOP9uxIDzszvtJpxOID7uk9+t/mbVA0pJYkp3uXD8SfwqdlRqSFEDpJ2eCL1ExClSWJBPAt0u1JCwNJBFmu/m9poJSkLbSN4ZO/lvUfFwVIuNI6kQ92Y9+K7rWkOiDyJd+pc+hFNqIUoaypRbjndnoH04niYDSdmhgerBh2riiSlaS4cEkqJKnH5loem8fEAGl1E92boZ4qMlalCHSn/ALvmDemDKYq/GehqTgqdqb9o4RRiKB3kedKwTWGzftXDdBqhy2IpCnBrTZhigjis8tAoLbAzgWxBYipq1VkF4xQXFaTCzIUhB5ANEdxcRqRlsydVGKXqtzOaCFpHUD1oNdhkKAoxsMAXY1zIEFA5mjGEVKRWe3F+FM7Uz7Mxeab9ur8KO5qNkcyIpIraZYgpDkCNy1T042rwky38r6R9DbpVFksdKgJaG/R6tCpJACSFhpuG9DPatSYxakoWgpPg1JZWlwRL9RFqyWYxNSlEMliwnqd+bfGrf2pjlKQgKZ2JgQTAAIL+dZ9C0lRm0X5DgNy8UpDaULxPEk6GWkcu5IJjvahKPE5BKiZO5qYjA0IdSgVFyAnYE77vSVKClDZoDbtPzNFPez8DUoMIHl5PWpy6NIAJckOSLv2HfyqtyyAhIO5H19d6lIJMlnbhoFVUrBUn3lJURYNIJ+BAal5mS7aJgOoi0l70jGxHJILJTASXDdWLOSX+A2pWYW4gw7+63FRnTSVlwQ7W+f15Vk/2qav3XDBSGGKiRv4Ft+NbJKUsNRMvvpAb3SOZesX+09X/AEmGAoKH3ydmL6Fi361R8poooqKKsvs4HzeWH/vYf96aras/s4ps3liWYY2GZt76b0H2/GwiXDnoG0j4WHak4YUlwFFjDgkD1PbinAgFz94gg3kM1xH60wvGRdC0TyQR6GG/StIdTqAMJLlvEX9LOPW9cwMKT4tQDP0Jhtn/AEp3BxkAeNaJtYTeA9JRjIUQdelKeSHJ5jagdVhe8SB0Eu4EbT2plRHE3O3reX4pWJmlEBKiGTL6wIeHsL88UlSkge+lr+FSHfcw/wBGgQcUkEjxNdvE0sHZ32pIQdgQegZwevn8KSjGSgnUQ+wJDd/eYR0NNJzIIPjQHY+8BDfB6BLwwDmXYnnaJtSVEAEnVFrwoDY0pS8MABWlgZkfh+lKXmEBIS6A5KndJD2N97TQVPtlWoJWynEeJph9tqiZVMVO9qY2EpCwnESWIZoDjobedQsniJ3UH7isX1qE5sEIUehrI42YIMVtM8tBw1jUHY7iseMAKS+oPw9FQMXFUq9T/ZebIdJMbUwrLWkT1ruayuhIUkgl2M0RPzHtHx6Xqrxlla9RsDHlQMNSiIncvSwlQBQfKzP1qjfezFPhoUOB8am40hqp/YGMBhIBUmAdxcGrtakMDrTbkVKMx7ZQSEJAc6jTOQ9mm5jgXLvx61a+0CgKS6gexFTsuMPS7gAkEEmC14qwOZbKXSIZLFzu5NubT1qSElASlQ5YlyXbZujC/wCVGFmEiQtIOwcH8b1C9tZ10BOoFTncMwZm+Lv0rTNVuex9alGw9bQKj5PKaScRYBUfdTxDO1juKYwcHXilaljQgOA8XsO6pqZi5rUSdSRwH24FZaL98uTE222qb7LyetUJASG7dKrErSQEg7nceQvWty2GjDw0grQCbnUnYAneZLeRqobUjqwEM8DYTTqUlXhgcEv07fGlLzwKQnWnSC8aUupm2tv1LzUPB9qJKtGkkvdww6noz77VNFmEK0eJi0ggAmOpnyeuZfBJVYhpIAHHRqbXiITIUlz1Sw5JFCMykuhWIklgbho4Yjnaqh1QIgKa0fl6msd+1DCCcqi5P3yZ6FC61hxkD+did9Qb0FpFZH9p2KlWVQxf+Mnf/ZiUHyyiiiooooooCiiigKKKKAooooCiiigKKKKAooooCiiigKKKKAooooCiiigKKKKAooooCiiigKKKKAooooCiiigKKKKAooooP//Z",
          publishedAt: "2021-03-24T12:37:04Z",
          content:
            "Performance-orientiert, ohne Abstriche bei Komfort und Luxus: Das verspricht der neue Bentley Continental GT Speed. Mit 659 PS, 900 Nm Drehmoment und sechs Liter Hubraum will das mittlerweile dritte … [+3438 chars]",
        },
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