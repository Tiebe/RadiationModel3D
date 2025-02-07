using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sulfur35 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur35";
        public override double halfLife { get; } = 7548768.0d;
        public override double atomicWeight { get; } = 34.96903d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine35()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0140246d },
            { 500.0d, 0.0136236d },
            { 1000.0d, 0.0133907d },
            { 1500.0d, 0.0133258d },
            { 2000.0d, 0.0132728d },
            { 2500.0d, 0.0132179d },
            { 3000.0d, 0.0131612d },
            { 3500.0d, 0.0131043d },
            { 4000.0d, 0.0130485d },
            { 4500.0d, 0.0129943d },
            { 5000.0d, 0.012942d },
            { 5500.0d, 0.0128917d },
            { 6000.0d, 0.0128433d },
            { 6500.0d, 0.0127968d },
            { 7000.0d, 0.012752d },
            { 7500.0d, 0.0127087d },
            { 8000.0d, 0.0126668d },
            { 8500.0d, 0.0126261d },
            { 9000.0d, 0.0125865d },
            { 9500.0d, 0.0125478d },
            { 10000.0d, 0.01251d },
            { 10500.0d, 0.0124728d },
            { 11000.0d, 0.0124363d },
            { 11500.0d, 0.0124003d },
            { 12000.0d, 0.0123646d },
            { 12500.0d, 0.0123294d },
            { 13000.0d, 0.0122944d },
            { 13500.0d, 0.0122597d },
            { 14000.0d, 0.0122251d },
            { 14500.0d, 0.0121906d },
            { 15000.0d, 0.0121563d },
            { 15500.0d, 0.0121219d },
            { 16000.0d, 0.0120876d },
            { 16500.0d, 0.0120533d },
            { 17000.0d, 0.0120189d },
            { 17500.0d, 0.0119844d },
            { 18000.0d, 0.0119498d },
            { 18500.0d, 0.0119151d },
            { 19000.0d, 0.0118803d },
            { 19500.0d, 0.0118452d },
            { 20000.0d, 0.0118101d },
            { 20500.0d, 0.0117747d },
            { 21000.0d, 0.0117391d },
            { 21500.0d, 0.0117034d },
            { 22000.0d, 0.0116674d },
            { 22500.0d, 0.0116312d },
            { 23000.0d, 0.0115948d },
            { 23500.0d, 0.0115581d },
            { 24000.0d, 0.0115212d },
            { 24500.0d, 0.011484d },
            { 25000.0d, 0.0114466d },
            { 25500.0d, 0.0114089d },
            { 26000.0d, 0.011371d },
            { 26500.0d, 0.0113328d },
            { 27000.0d, 0.0112943d },
            { 27500.0d, 0.0112556d },
            { 28000.0d, 0.0112166d },
            { 28500.0d, 0.0111773d },
            { 29000.0d, 0.0111378d },
            { 29500.0d, 0.011098d },
            { 30000.0d, 0.0110579d },
            { 30500.0d, 0.0110176d },
            { 31000.0d, 0.010977d },
            { 31500.0d, 0.0109361d },
            { 32000.0d, 0.010895d },
            { 32500.0d, 0.0108536d },
            { 33000.0d, 0.0108119d },
            { 33500.0d, 0.01077d },
            { 34000.0d, 0.0107278d },
            { 34500.0d, 0.0106854d },
            { 35000.0d, 0.0106427d },
            { 35500.0d, 0.0105997d },
            { 36000.0d, 0.0105565d },
            { 36500.0d, 0.0105131d },
            { 37000.0d, 0.0104694d },
            { 37500.0d, 0.0104254d },
            { 38000.0d, 0.0103812d },
            { 38500.0d, 0.0103368d },
            { 39000.0d, 0.0102921d },
            { 39500.0d, 0.0102472d },
            { 40000.0d, 0.0102021d },
            { 40500.0d, 0.0101567d },
            { 41000.0d, 0.0101112d },
            { 41500.0d, 0.0100653d },
            { 42000.0d, 0.0100193d },
            { 42500.0d, 0.00997306d },
            { 43000.0d, 0.00992659d },
            { 43500.0d, 0.00987991d },
            { 44000.0d, 0.00983303d },
            { 44500.0d, 0.00978593d },
            { 45000.0d, 0.00973864d },
            { 45500.0d, 0.00969114d },
            { 46000.0d, 0.00964345d },
            { 46500.0d, 0.00959556d },
            { 47000.0d, 0.00954748d },
            { 47500.0d, 0.00949921d },
            { 48000.0d, 0.00945076d },
            { 48500.0d, 0.00940213d },
            { 49000.0d, 0.00935332d },
            { 49500.0d, 0.00930434d },
            { 50000.0d, 0.00925519d },
            { 50500.0d, 0.00920586d },
            { 51000.0d, 0.00915637d },
            { 51500.0d, 0.00910672d },
            { 52000.0d, 0.00905691d },
            { 52500.0d, 0.00900695d },
            { 53000.0d, 0.00895683d },
            { 53500.0d, 0.00890657d },
            { 54000.0d, 0.00885616d },
            { 54500.0d, 0.00880561d },
            { 55000.0d, 0.00875491d },
            { 55500.0d, 0.00870408d },
            { 56000.0d, 0.00865312d },
            { 56500.0d, 0.00860203d },
            { 57000.0d, 0.00855082d },
            { 57500.0d, 0.00849948d },
            { 58000.0d, 0.00844802d },
            { 58500.0d, 0.00839645d },
            { 59000.0d, 0.00834476d },
            { 59500.0d, 0.00829296d },
            { 60000.0d, 0.00824106d },
            { 60500.0d, 0.00818905d },
            { 61000.0d, 0.00813694d },
            { 61500.0d, 0.00808474d },
            { 62000.0d, 0.00803244d },
            { 62500.0d, 0.00798006d },
            { 63000.0d, 0.00792758d },
            { 63500.0d, 0.00787502d },
            { 64000.0d, 0.00782239d },
            { 64500.0d, 0.00776967d },
            { 65000.0d, 0.00771688d },
            { 65500.0d, 0.00766402d },
            { 66000.0d, 0.00761109d },
            { 66500.0d, 0.0075581d },
            { 67000.0d, 0.00750505d },
            { 67500.0d, 0.00745194d },
            { 68000.0d, 0.00739878d },
            { 68500.0d, 0.00734556d },
            { 69000.0d, 0.0072923d },
            { 69500.0d, 0.00723899d },
            { 70000.0d, 0.00718564d },
            { 70500.0d, 0.00713225d },
            { 71000.0d, 0.00707883d },
            { 71500.0d, 0.00702537d },
            { 72000.0d, 0.00697189d },
            { 72500.0d, 0.00691838d },
            { 73000.0d, 0.00686485d },
            { 73500.0d, 0.00681129d },
            { 74000.0d, 0.00675773d },
            { 74500.0d, 0.00670415d },
            { 75000.0d, 0.00665056d },
            { 75500.0d, 0.00659697d },
            { 76000.0d, 0.00654337d },
            { 76500.0d, 0.00648977d },
            { 77000.0d, 0.00643618d },
            { 77500.0d, 0.00638259d },
            { 78000.0d, 0.00632901d },
            { 78500.0d, 0.00627545d },
            { 79000.0d, 0.0062219d },
            { 79500.0d, 0.00616837d },
            { 80000.0d, 0.00611487d },
            { 80500.0d, 0.00606138d },
            { 81000.0d, 0.00600793d },
            { 81500.0d, 0.00595451d },
            { 82000.0d, 0.00590113d },
            { 82500.0d, 0.00584778d },
            { 83000.0d, 0.00579448d },
            { 83500.0d, 0.00574122d },
            { 84000.0d, 0.00568801d },
            { 84500.0d, 0.00563485d },
            { 85000.0d, 0.00558175d },
            { 85500.0d, 0.0055287d },
            { 86000.0d, 0.00547571d },
            { 86500.0d, 0.00542279d },
            { 87000.0d, 0.00536993d },
            { 87500.0d, 0.00531715d },
            { 88000.0d, 0.00526443d },
            { 88500.0d, 0.0052118d },
            { 89000.0d, 0.00515924d },
            { 89500.0d, 0.00510677d },
            { 90000.0d, 0.00505438d },
            { 90500.0d, 0.00500209d },
            { 91000.0d, 0.00494988d },
            { 91500.0d, 0.00489777d },
            { 92000.0d, 0.00484576d },
            { 92500.0d, 0.00479385d },
            { 93000.0d, 0.00474205d },
            { 93500.0d, 0.00469035d },
            { 94000.0d, 0.00463877d },
            { 94500.0d, 0.0045873d },
            { 95000.0d, 0.00453595d },
            { 95500.0d, 0.00448472d },
            { 96000.0d, 0.00443361d },
            { 96500.0d, 0.00438263d },
            { 97000.0d, 0.00433178d },
            { 97500.0d, 0.00428107d },
            { 98000.0d, 0.00423049d },
            { 98500.0d, 0.00418005d },
            { 99000.0d, 0.00412976d },
            { 99500.0d, 0.00407961d },
            { 100000.0d, 0.00402961d },
            { 100500.0d, 0.00397976d },
            { 101000.0d, 0.00393007d },
            { 101500.0d, 0.00388054d },
            { 102000.0d, 0.00383117d },
            { 102500.0d, 0.00378197d },
            { 103000.0d, 0.00373293d },
            { 103500.0d, 0.00368407d },
            { 104000.0d, 0.00363538d },
            { 104500.0d, 0.00358686d },
            { 105000.0d, 0.00353853d },
            { 105500.0d, 0.00349039d },
            { 106000.0d, 0.00344243d },
            { 106500.0d, 0.00339466d },
            { 107000.0d, 0.00334709d },
            { 107500.0d, 0.00329971d },
            { 108000.0d, 0.00325253d },
            { 108500.0d, 0.00320556d },
            { 109000.0d, 0.0031588d },
            { 109500.0d, 0.00311224d },
            { 110000.0d, 0.0030659d },
            { 110500.0d, 0.00301977d },
            { 111000.0d, 0.00297386d },
            { 111500.0d, 0.00292817d },
            { 112000.0d, 0.00288271d },
            { 112500.0d, 0.00283748d },
            { 113000.0d, 0.00279248d },
            { 113500.0d, 0.00274772d },
            { 114000.0d, 0.0027032d },
            { 114500.0d, 0.00265891d },
            { 115000.0d, 0.00261487d },
            { 115500.0d, 0.00257108d },
            { 116000.0d, 0.00252755d },
            { 116500.0d, 0.00248426d },
            { 117000.0d, 0.00244124d },
            { 117500.0d, 0.00239847d },
            { 118000.0d, 0.00235597d },
            { 118500.0d, 0.00231373d },
            { 119000.0d, 0.00227177d },
            { 119500.0d, 0.00223008d },
            { 120000.0d, 0.00218867d },
            { 120500.0d, 0.00214754d },
            { 121000.0d, 0.00210669d },
            { 121500.0d, 0.00206612d },
            { 122000.0d, 0.00202585d },
            { 122500.0d, 0.00198587d },
            { 123000.0d, 0.00194619d },
            { 123500.0d, 0.00190681d },
            { 124000.0d, 0.00186773d },
            { 124500.0d, 0.00182895d },
            { 125000.0d, 0.00179049d },
            { 125500.0d, 0.00175233d },
            { 126000.0d, 0.0017145d },
            { 126500.0d, 0.00167698d },
            { 127000.0d, 0.00163978d },
            { 127500.0d, 0.00160291d },
            { 128000.0d, 0.00156637d },
            { 128500.0d, 0.00153016d },
            { 129000.0d, 0.00149429d },
            { 129500.0d, 0.00145875d },
            { 130000.0d, 0.00142356d },
            { 130500.0d, 0.00138871d },
            { 131000.0d, 0.00135421d },
            { 131500.0d, 0.00132006d },
            { 132000.0d, 0.00128627d },
            { 132500.0d, 0.00125283d },
            { 133000.0d, 0.00121976d },
            { 133500.0d, 0.00118705d },
            { 134000.0d, 0.00115471d },
            { 134500.0d, 0.00112274d },
            { 135000.0d, 0.00109114d },
            { 135500.0d, 0.00105992d },
            { 136000.0d, 0.00102909d },
            { 136500.0d, 0.000998633d },
            { 137000.0d, 0.000968568d },
            { 137500.0d, 0.000938894d },
            { 138000.0d, 0.000909614d },
            { 138500.0d, 0.000880731d },
            { 139000.0d, 0.00085225d },
            { 139500.0d, 0.000824172d },
            { 140000.0d, 0.000796503d },
            { 140500.0d, 0.000769244d },
            { 141000.0d, 0.000742399d },
            { 141500.0d, 0.000715971d },
            { 142000.0d, 0.000689964d },
            { 142500.0d, 0.000664381d },
            { 143000.0d, 0.000639226d },
            { 143500.0d, 0.000614501d },
            { 144000.0d, 0.00059021d },
            { 144500.0d, 0.000566357d },
            { 145000.0d, 0.000542944d },
            { 145500.0d, 0.000519976d },
            { 146000.0d, 0.000497455d },
            { 146500.0d, 0.000475384d },
            { 147000.0d, 0.000453768d },
            { 147500.0d, 0.000432609d },
            { 148000.0d, 0.00041191d },
            { 148500.0d, 0.000391676d },
            { 149000.0d, 0.000371909d },
            { 149500.0d, 0.000352613d },
            { 150000.0d, 0.000333792d },
            { 150500.0d, 0.000315448d },
            { 151000.0d, 0.000297584d },
            { 151500.0d, 0.000280205d },
            { 152000.0d, 0.000263314d },
            { 152500.0d, 0.000246914d },
            { 153000.0d, 0.000231008d },
            { 153500.0d, 0.0002156d },
            { 154000.0d, 0.000200693d },
            { 154500.0d, 0.00018629d },
            { 155000.0d, 0.000172396d },
            { 155500.0d, 0.000159013d },
            { 156000.0d, 0.000146144d },
            { 156500.0d, 0.000133794d },
            { 157000.0d, 0.000121965d },
            { 157500.0d, 0.000110661d },
            { 158000.0d, 0.0000998849d },
            { 158500.0d, 0.0000896408d },
            { 159000.0d, 0.0000799317d },
            { 159500.0d, 0.0000707612d },
            { 160000.0d, 0.0000621325d },
            { 160500.0d, 0.000054049d },
            { 161000.0d, 0.0000465143d },
            { 161500.0d, 0.0000395316d },
            { 162000.0d, 0.0000331044d },
            { 162500.0d, 0.0000272361d },
            { 163000.0d, 0.00002193d },
            { 163500.0d, 0.0000171897d },
            { 164000.0d, 0.0000130184d },
            { 164500.0d, 0.00000941951d },
            { 165000.0d, 0.00000639647d },
            { 165500.0d, 0.0000039526d },
            { 166000.0d, 0.00000209124d },
            { 166500.0d, 0.000000815666d },
            { 167000.0d, 0.000000129078d },
            { 167330.0d, 0d },

        }; 
    }
}
    