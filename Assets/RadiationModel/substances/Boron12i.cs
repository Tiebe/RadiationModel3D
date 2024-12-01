using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Boron12i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron12i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.02801d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium8()), new(1.0d, new AlphaParticle(3739202.0900000003)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    