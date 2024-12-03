using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium107m";
        public override double halfLife { get; } = 50.4d;
        public override double atomicWeight { get; } = 106.91102d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium107()), new(0.943d, new GammaParticle(678400.0, 0.00183)), new(0.0052153090272000005d, new GammaParticle(3571.0, 0.3472)), new(0.016954385629256483d, new GammaParticle(24001.0, 0.05166)), new(0.03180935390104406d, new GammaParticle(24209.0, 0.05121)), new(0.008924993672016351d, new GammaParticle(27367.0, 0.0453)), new(0.010620742469699457d, new GammaParticle(27581.0, 0.04495)), new(0.0016957487976831068d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    