using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury170 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury170";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 170.00582d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum166()), new(1.0d, new AlphaParticle(8797002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    