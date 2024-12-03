using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 176.94393d;

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
    