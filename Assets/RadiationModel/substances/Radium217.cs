using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium217";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.00632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon213()), new(1.0d, new AlphaParticle(10183002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    