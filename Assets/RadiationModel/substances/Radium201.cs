using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 201.01281d;

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
    