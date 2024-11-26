using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium99";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 98.94512d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium99() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.198d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium99() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    