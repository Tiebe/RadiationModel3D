using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium140m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 139.95635d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium140() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    