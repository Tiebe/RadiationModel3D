using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium252";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 252.08639d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium252()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    