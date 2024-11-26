using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton100 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton100";
        public override double halfLife { get; } = 0.007d;
        public override double atomicWeight { get; } = 99.96299d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium100() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
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
    