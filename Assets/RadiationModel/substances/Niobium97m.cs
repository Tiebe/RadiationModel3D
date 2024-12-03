using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium97m";
        public override double halfLife { get; } = 58.7d;
        public override double atomicWeight { get; } = 96.9089d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium97()), new(0.9790000000000001d, new GammaParticle(743360.0, 0.00167)), new(0.000724905077875d, new GammaParticle(2299.0, 0.5393)), new(0.0038366396662393707d, new GammaParticle(16521.0, 0.07505)), new(0.007327424878226452d, new GammaParticle(16615.0, 0.07462)), new(0.0018959493961166745d, new GammaParticle(18694.0, 0.06632)), new(0.0021803418055341755d, new GammaParticle(18795.0, 0.06597)), new(0.0002843924094175012d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    