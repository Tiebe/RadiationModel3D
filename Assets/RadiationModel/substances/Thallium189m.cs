using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium189m";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 188.97388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold189() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium189() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    