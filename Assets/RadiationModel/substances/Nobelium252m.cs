using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium252m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium252m";
        public override double halfLife { get; } = 0.109d;
        public override double atomicWeight { get; } = 252.09031d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium252()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    