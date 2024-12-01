using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium209";
        public override double halfLife { get; } = 0.087d;
        public override double atomicWeight { get; } = 209.00949d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium205()), new(1.0d, new AlphaParticle(8747002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    