using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium217";
        public override double halfLife { get; } = 0.00025d;
        public override double atomicWeight { get; } = 217.0131d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium213()), new(1.0d, new AlphaParticle(10457002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    