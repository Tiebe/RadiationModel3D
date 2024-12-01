using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium140m";
        public override double halfLife { get; } = 0.0006d;
        public override double atomicWeight { get; } = 139.91193d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium140()), new(0.9436d, new GammaParticle(419810.0, 0.00295)), new(0.99606d, new GammaParticle(773740.0, 0.0016)), new(0.99789d, new GammaParticle(1028190.0, 0.00121)), new(0.0073899532d, new GammaParticle(5870.0, 0.21122)), new(0.012094317877611189d, new GammaParticle(36848.0, 0.03365)), new(0.022025710940832614d, new GammaParticle(37362.0, 0.03318)), new(0.006764288927252343d, new GammaParticle(42380.0, 0.02926)), new(0.008502711181556195d, new GammaParticle(42810.0, 0.02896)), new(0.0017384222543038522d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    