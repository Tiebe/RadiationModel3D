using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Oxygen25 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen25";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 25.02934d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen24()), new(1.0d, new NeutronParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    