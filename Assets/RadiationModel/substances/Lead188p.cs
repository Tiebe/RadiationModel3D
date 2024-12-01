using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead188p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead188p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 187.98601d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    