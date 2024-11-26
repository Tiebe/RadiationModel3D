using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium118";
        public override double halfLife { get; } = 0.099d;
        public override double atomicWeight { get; } = 117.93881d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium118() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.046d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium118() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    