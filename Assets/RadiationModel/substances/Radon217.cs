using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon217 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon217";
        public override double halfLife { get; } = 0.00054d;
        public override double atomicWeight { get; } = 217.00393d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium213()), new(1.0d, new AlphaParticle(8910002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    