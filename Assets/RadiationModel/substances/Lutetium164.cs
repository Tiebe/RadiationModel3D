using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium164";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.94134d;

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
    