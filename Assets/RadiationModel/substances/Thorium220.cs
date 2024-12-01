using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium220";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 220.01577d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium216()), new(1.0d, new AlphaParticle(9996002.09)) } },
            { 1.9999999999999997e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium220()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    