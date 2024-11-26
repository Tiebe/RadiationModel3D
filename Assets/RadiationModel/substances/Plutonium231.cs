using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium231";
        public override double halfLife { get; } = 516.0d;
        public override double atomicWeight { get; } = 231.04113d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium231() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium227() }, { 1.0d, new AlphaParticle(7861002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    