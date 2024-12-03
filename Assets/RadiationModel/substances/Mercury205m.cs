using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury205m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury205m";
        public override double halfLife { get; } = 0.00109d;
        public override double atomicWeight { get; } = 204.97774d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury205()), new(0.0125d, new GammaParticle(49000.0, 0.0253)), new(0.06509999999999999d, new GammaParticle(161400.0, 0.00768)), new(0.048d, new GammaParticle(210300.0, 0.0059)), new(0.929d, new GammaParticle(379420.0, 0.00327)), new(0.0182d, new GammaParticle(467580.0, 0.00265)), new(0.0202d, new GammaParticle(878830.0, 0.00141)), new(0.308d, new GammaParticle(966620.0, 0.00128)), new(0.662d, new GammaParticle(1015630.0, 0.00122)), new(0.305531466958d, new GammaParticle(11777.0, 0.10528)), new(0.16856596662249412d, new GammaParticle(68894.0, 0.018)), new(0.2857534609637127d, new GammaParticle(70820.0, 0.01751)), new(0.09697769683974718d, new GammaParticle(80316.0, 0.01544)), new(0.1253921620137931d, new GammaParticle(81285.0, 0.01525)), new(0.028414465174045923d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    