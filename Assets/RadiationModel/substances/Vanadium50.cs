using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium50";
        public override double halfLife { get; } = 8.36258538326688e+24d;
        public override double atomicWeight { get; } = 49.94716d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium50()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.993d, new GammaParticle(1553770.0, 0.0008)), new(0.0047475821603556725d, new GammaParticle(477.0, 2.59925)), new(0.05955021466364651d, new GammaParticle(4505.0, 0.27521)), new(0.11731720776920117d, new GammaParticle(4511.0, 0.27485)), new(0.023434933472352322d, new GammaParticle(4947.0, 0.25063)), new(0.023434933472352322d, new GammaParticle(4947.0, 0.25063)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium50()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000629555d },
            { 800.0d, 0.0000069373d },
            { 1600.0d, 0.00000744032d },
            { 2400.0d, 0.00000780461d },
            { 3200.0d, 0.00000812768d },
            { 4000.0d, 0.00000843102d },
            { 4800.0d, 0.00000872324d },
            { 5600.0d, 0.00000900878d },
            { 6400.0d, 0.00000929021d },
            { 7200.0d, 0.00000956913d },
            { 8000.0d, 0.00000984658d },
            { 8800.0d, 0.0000101232d },
            { 9600.0d, 0.0000103995d },
            { 10000.0d, 0.0000105377d },
            { 10800.0d, 0.000010814d },
            { 11600.0d, 0.0000110907d },
            { 12400.0d, 0.0000113678d },
            { 13200.0d, 0.0000116452d },
            { 14000.0d, 0.0000119233d },
            { 14800.0d, 0.0000122019d },
            { 15600.0d, 0.0000124811d },
            { 16400.0d, 0.0000127608d },
            { 17200.0d, 0.0000130411d },
            { 18000.0d, 0.0000133219d },
            { 18800.0d, 0.0000136032d },
            { 19600.0d, 0.0000138849d },
            { 20400.0d, 0.0000141672d },
            { 21200.0d, 0.0000144499d },
            { 22000.0d, 0.000014733d },
            { 22800.0d, 0.0000150165d },
            { 23600.0d, 0.0000153002d },
            { 24400.0d, 0.0000155842d },
            { 25200.0d, 0.0000158685d },
            { 26000.0d, 0.000016153d },
            { 26800.0d, 0.0000164377d },
            { 27600.0d, 0.0000167225d },
            { 28400.0d, 0.0000170075d },
            { 29200.0d, 0.0000172925d },
            { 30000.0d, 0.0000175775d },
            { 30800.0d, 0.0000178625d },
            { 31600.0d, 0.0000181475d },
            { 32400.0d, 0.0000184324d },
            { 33200.0d, 0.0000187172d },
            { 34000.0d, 0.0000190019d },
            { 34800.0d, 0.0000192863d },
            { 35600.0d, 0.0000195705d },
            { 36400.0d, 0.0000198545d },
            { 37200.0d, 0.0000201382d },
            { 38000.0d, 0.0000204215d },
            { 38800.0d, 0.0000207046d },
            { 39600.0d, 0.0000209871d },
            { 40400.0d, 0.0000212692d },
            { 41200.0d, 0.0000215509d },
            { 42000.0d, 0.0000218321d },
            { 42800.0d, 0.0000221128d },
            { 43600.0d, 0.0000223929d },
            { 44400.0d, 0.0000226723d },
            { 45200.0d, 0.0000229511d },
            { 46000.0d, 0.0000232293d },
            { 46800.0d, 0.0000235069d },
            { 47600.0d, 0.0000237836d },
            { 48400.0d, 0.0000240595d },
            { 49200.0d, 0.0000243347d },
            { 50000.0d, 0.0000246091d },
            { 50800.0d, 0.0000248825d },
            { 51600.0d, 0.0000251551d },
            { 52400.0d, 0.0000254268d },
            { 53200.0d, 0.0000256975d },
            { 54000.0d, 0.0000259672d },
            { 54800.0d, 0.0000262359d },
            { 55600.0d, 0.0000265036d },
            { 56400.0d, 0.0000267702d },
            { 57200.0d, 0.0000270357d },
            { 58000.0d, 0.0000273d },
            { 58800.0d, 0.0000275631d },
            { 59600.0d, 0.0000278251d },
            { 60400.0d, 0.0000280858d },
            { 61200.0d, 0.0000283453d },
            { 62000.0d, 0.0000286035d },
            { 62800.0d, 0.0000288604d },
            { 63600.0d, 0.0000291159d },
            { 64400.00000000001d, 0.0000293701d },
            { 65200.0d, 0.0000296228d },
            { 66000.0d, 0.0000298742d },
            { 66800.0d, 0.000030124d },
            { 67600.0d, 0.0000303724d },
            { 68400.0d, 0.0000306192d },
            { 69200.0d, 0.0000308645d },
            { 70000.0d, 0.0000311083d },
            { 70800.0d, 0.0000313505d },
            { 71600.0d, 0.000031591d },
            { 72400.0d, 0.0000318298d },
            { 73200.0d, 0.000032067d },
            { 74000.0d, 0.0000323024d },
            { 74800.0d, 0.0000325362d },
            { 75600.0d, 0.0000327681d },
            { 76400.0d, 0.0000329983d },
            { 77200.0d, 0.0000332266d },
            { 78000.0d, 0.0000334531d },
            { 78800.0d, 0.0000336778d },
            { 79600.0d, 0.0000339005d },
            { 80400.0d, 0.0000341213d },
            { 81200.0d, 0.0000343402d },
            { 82000.0d, 0.000034557d },
            { 82800.0d, 0.0000347719d },
            { 83600.0d, 0.0000349847d },
            { 84400.0d, 0.0000351954d },
            { 85200.0d, 0.0000354041d },
            { 86000.0d, 0.0000356106d },
            { 86800.0d, 0.000035815d },
            { 87600.0d, 0.0000360172d },
            { 88400.0d, 0.0000362172d },
            { 89200.0d, 0.000036415d },
            { 90000.0d, 0.0000366106d },
            { 90800.0d, 0.0000368039d },
            { 91600.0d, 0.0000369949d },
            { 92400.0d, 0.0000371835d },
            { 93200.0d, 0.0000373697d },
            { 94000.0d, 0.0000375537d },
            { 94800.0d, 0.0000377351d },
            { 95600.0d, 0.0000379141d },
            { 96400.0d, 0.0000380907d },
            { 97200.0d, 0.0000382647d },
            { 98000.0d, 0.0000384363d },
            { 98800.0d, 0.0000386052d },
            { 99600.0d, 0.0000387716d },
            { 100400.0d, 0.0000389354d },
            { 101200.0d, 0.0000390965d },
            { 102000.0d, 0.000039255d },
            { 102800.0d, 0.0000394107d },
            { 103600.0d, 0.0000395637d },
            { 104400.0d, 0.000039714d },
            { 105200.0d, 0.0000398615d },
            { 106000.0d, 0.0000400062d },
            { 106800.0d, 0.000040148d },
            { 107600.0d, 0.0000402869d },
            { 108400.0d, 0.000040423d },
            { 109200.0d, 0.0000405561d },
            { 110000.0d, 0.0000406862d },
            { 110800.0d, 0.0000408133d },
            { 111600.0d, 0.0000409374d },
            { 112400.0d, 0.0000410584d },
            { 113200.0d, 0.0000411764d },
            { 114000.0d, 0.0000412911d },
            { 114800.0d, 0.0000414028d },
            { 115600.0d, 0.0000415112d },
            { 116400.0d, 0.0000416165d },
            { 117200.0d, 0.0000417185d },
            { 118000.0d, 0.0000418171d },
            { 118800.0d, 0.0000419125d },
            { 119600.0d, 0.0000420044d },
            { 120400.0d, 0.000042093d },
            { 121200.0d, 0.0000421781d },
            { 122000.0d, 0.0000422598d },
            { 122800.0d, 0.0000423381d },
            { 123600.0d, 0.0000424127d },
            { 124400.0d, 0.0000424838d },
            { 125200.0d, 0.0000425512d },
            { 126000.0d, 0.0000426151d },
            { 126800.0d, 0.0000426752d },
            { 127600.0d, 0.0000427316d },
            { 128400.0d, 0.0000427842d },
            { 129199.99999999999d, 0.0000428331d },
            { 130000.0d, 0.0000428781d },
            { 130800.00000000001d, 0.0000429192d },
            { 131600.0d, 0.0000429564d },
            { 132400.0d, 0.0000429898d },
            { 133200.0d, 0.000043019d },
            { 134000.0d, 0.0000430442d },
            { 134800.0d, 0.0000430655d },
            { 135600.0d, 0.0000430825d },
            { 136400.0d, 0.0000430954d },
            { 137200.0d, 0.0000431041d },
            { 138000.0d, 0.0000431086d },
            { 138800.0d, 0.0000431088d },
            { 139600.0d, 0.0000431047d },
            { 140400.0d, 0.0000430962d },
            { 141200.0d, 0.0000430834d },
            { 142000.0d, 0.0000430661d },
            { 142800.0d, 0.0000430442d },
            { 143600.0d, 0.0000430179d },
            { 144400.0d, 0.000042987d },
            { 145200.0d, 0.0000429515d },
            { 146000.0d, 0.0000429113d },
            { 146800.0d, 0.0000428664d },
            { 147600.0d, 0.0000428168d },
            { 148400.0d, 0.0000427624d },
            { 149200.0d, 0.0000427032d },
            { 150000.0d, 0.000042639d },
            { 150800.0d, 0.00004257d },
            { 151600.0d, 0.000042496d },
            { 152400.0d, 0.000042417d },
            { 153200.0d, 0.0000423329d },
            { 154000.0d, 0.0000422438d },
            { 154800.0d, 0.0000421495d },
            { 155600.0d, 0.0000420501d },
            { 156400.0d, 0.0000419455d },
            { 157200.0d, 0.0000418356d },
            { 158000.0d, 0.0000417204d },
            { 158800.0d, 0.0000415999d },
            { 159600.0d, 0.000041474d },
            { 160400.0d, 0.0000413426d },
            { 161200.0d, 0.0000412058d },
            { 162000.0d, 0.0000410636d },
            { 162800.0d, 0.0000409158d },
            { 163600.0d, 0.0000407624d },
            { 164400.0d, 0.0000406034d },
            { 165200.0d, 0.0000404388d },
            { 166000.0d, 0.0000402684d },
            { 166800.0d, 0.0000400924d },
            { 167600.0d, 0.0000399106d },
            { 168400.0d, 0.000039723d },
            { 169200.0d, 0.0000395297d },
            { 170000.0d, 0.0000393304d },
            { 170800.0d, 0.0000391253d },
            { 171600.0d, 0.0000389143d },
            { 172400.0d, 0.0000386974d },
            { 173200.0d, 0.0000384745d },
            { 174000.0d, 0.0000382458d },
            { 174800.0d, 0.0000380109d },
            { 175600.0d, 0.00003777d },
            { 176400.0d, 0.0000375231d },
            { 177200.0d, 0.0000372702d },
            { 178000.0d, 0.0000370112d },
            { 178800.0d, 0.0000367461d },
            { 179600.0d, 0.0000364749d },
            { 180400.0d, 0.0000361976d },
            { 181200.0d, 0.0000359143d },
            { 182000.0d, 0.0000356248d },
            { 182800.0d, 0.0000353291d },
            { 183600.0d, 0.0000350275d },
            { 184400.0d, 0.0000347197d },
            { 185200.0d, 0.0000344058d },
            { 186000.0d, 0.0000340858d },
            { 186800.0d, 0.0000337597d },
            { 187600.0d, 0.0000334276d },
            { 188400.0d, 0.0000330895d },
            { 189200.0d, 0.0000327453d },
            { 190000.0d, 0.0000323952d },
            { 190800.0d, 0.0000320391d },
            { 191600.0d, 0.0000316771d },
            { 192400.0d, 0.0000313092d },
            { 193200.0d, 0.0000309354d },
            { 194000.0d, 0.0000305559d },
            { 194800.0d, 0.0000301707d },
            { 195600.0d, 0.0000297797d },
            { 196400.0d, 0.0000293831d },
            { 197200.0d, 0.0000289811d },
            { 198000.0d, 0.0000285734d },
            { 198800.0d, 0.0000281604d },
            { 199600.0d, 0.0000277421d },
            { 200400.0d, 0.0000273186d },
            { 201200.0d, 0.0000268899d },
            { 202000.0d, 0.0000264561d },
            { 202800.0d, 0.0000260175d },
            { 203600.0d, 0.000025574d },
            { 204400.0d, 0.0000251258d },
            { 205200.0d, 0.0000246731d },
            { 206000.0d, 0.0000242159d },
            { 206800.0d, 0.0000237543d },
            { 207600.0d, 0.0000232887d },
            { 208400.0d, 0.0000228191d },
            { 209200.0d, 0.0000223456d },
            { 210000.0d, 0.0000218685d },
            { 210800.0d, 0.0000213879d },
            { 211600.0d, 0.000020904d },
            { 212400.0d, 0.000020417d },
            { 213200.0d, 0.0000199271d },
            { 214000.0d, 0.0000194346d },
            { 214800.0d, 0.0000189397d },
            { 215600.0d, 0.0000184426d },
            { 216400.0d, 0.0000179435d },
            { 217200.0d, 0.0000174428d },
            { 218000.0d, 0.0000169406d },
            { 218800.0d, 0.0000164372d },
            { 219600.0d, 0.000015933d },
            { 220400.0d, 0.0000154283d },
            { 221200.0d, 0.0000149234d },
            { 222000.0d, 0.0000144185d },
            { 222800.0d, 0.0000139141d },
            { 223600.0d, 0.0000134105d },
            { 224400.0d, 0.0000129081d },
            { 225200.0d, 0.0000124072d },
            { 226000.0d, 0.0000119082d },
            { 226800.0d, 0.0000114117d },
            { 227600.0d, 0.0000109179d },
            { 228400.0d, 0.0000104273d },
            { 229200.0d, 0.00000994036d },
            { 230000.0d, 0.00000945758d },
            { 230800.0d, 0.00000897946d },
            { 231600.0d, 0.00000850647d },
            { 232400.0d, 0.00000803914d },
            { 233200.0d, 0.00000757802d },
            { 234000.0d, 0.00000712365d },
            { 234800.0d, 0.00000667663d },
            { 235600.0d, 0.00000623753d },
            { 236400.0d, 0.00000580698d },
            { 237200.0d, 0.00000538561d },
            { 238000.0d, 0.00000497407d },
            { 238800.0d, 0.00000457303d },
            { 239600.0d, 0.0000041832d },
            { 240400.0d, 0.0000038053d },
            { 241200.0d, 0.00000344005d },
            { 242000.0d, 0.00000308822d },
            { 242800.0d, 0.00000275059d },
            { 243600.0d, 0.00000242799d },
            { 244400.0d, 0.00000212122d },
            { 245200.0d, 0.00000183116d },
            { 246000.0d, 0.00000155868d },
            { 246800.0d, 0.00000130468d },
            { 247600.0d, 0.00000107011d },
            { 248400.0d, 0.000000855923d },
            { 249200.0d, 0.000000663098d },
            { 250000.0d, 0.000000492652d },
            { 250800.0d, 0.000000345626d },
            { 251600.0d, 0.000000223087d },
            { 252400.0d, 0.000000126133d },
            { 253200.0d, 0.0000000558841d },
            { 254000.0d, 0.0000000134894d },
            { 254760.0d, 0d },

        }; 
    }
}
    