using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium229";
        public override double halfLife { get; } = 3480.0d;
        public override double atomicWeight { get; } = 229.03351d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.8d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium229()) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium225()), new(1.0d, new AlphaParticle(7498002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    