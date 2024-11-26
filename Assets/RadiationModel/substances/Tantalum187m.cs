using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum187m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum187m";
        public override double halfLife { get; } = 7.3d;
        public override double atomicWeight { get; } = 186.96231d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum187() } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten187() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    