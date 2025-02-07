using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium209";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 209.00199d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon205()), new(1.0d, new AlphaParticle(8165002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    