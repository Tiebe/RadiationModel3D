using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum182m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182m";
        public override double halfLife { get; } = 0.283d;
        public override double atomicWeight { get; } = 181.95017d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum182()), new(2.32e-05d, new GammaParticle(16273.0, 0.07619)), new(0.202912d, new GammaParticle(9424.0, 0.13156)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    