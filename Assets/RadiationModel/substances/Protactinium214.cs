using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium214";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 214.02089d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium210()), new(1.0d, new AlphaParticle(9297002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    