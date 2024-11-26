using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin138 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin138";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 137.95114d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony138() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony138() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
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
    