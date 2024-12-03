using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum91m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum91m";
        public override double halfLife { get; } = 64.6d;
        public override double atomicWeight { get; } = 90.91245d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum91()), new(0.48200000000000004d, new GammaParticle(652900.0, 0.0019)), new(0.00068738853378d, new GammaParticle(2440.0, 0.50813)), new(0.0034072172446853806d, new GammaParticle(17374.0, 0.07136)), new(0.006493648265076007d, new GammaParticle(17479.0, 0.07093)), new(0.0017039097835689877d, new GammaParticle(19681.0, 0.063)), new(0.0019663118902386117d, new GammaParticle(19794.0, 0.06264)), new(0.0002624021066696241d, new GammaParticle(19963.0, 0.06211)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium91()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0017000000000000001d, new GammaParticle(425900.0, 0.00291)), new(0.0017000000000000001d, new GammaParticle(732640.0, 0.00169)), new(0.0053d, new GammaParticle(1032740.0, 0.0012)), new(0.005d, new GammaParticle(1082180.0, 0.00115)), new(0.0028000000000000004d, new GammaParticle(1158540.0, 0.00107)), new(0.18600000000000003d, new GammaParticle(1208110.0, 0.00103)), new(0.242d, new GammaParticle(1508000.0, 0.00082)), new(0.0072d, new GammaParticle(2240700.0, 0.00055)), new(0.8815999999999999d, new GammaParticle(511000.0, 0.00243)), new(0.0021987948619254997d, new GammaParticle(2299.0, 0.5393)), new(0.011745622460052861d, new GammaParticle(16521.0, 0.07505)), new(0.0224324340337144d, new GammaParticle(16615.0, 0.07462)), new(0.005804325594115431d, new GammaParticle(18694.0, 0.06632)), new(0.006674974433232745d, new GammaParticle(18795.0, 0.06597)), new(0.0008706488391173146d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    