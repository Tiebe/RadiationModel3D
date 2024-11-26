using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium233";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 233.04759d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium233() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    