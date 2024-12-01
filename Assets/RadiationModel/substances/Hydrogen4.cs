using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hydrogen4 : RadioactiveSubstance
    {
        public override string name { get; } = "Hydrogen4";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 4.02643d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hydrogen3()), new(1.0d, new NeutronParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    