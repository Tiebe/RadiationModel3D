using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium202";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 202.00974d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon198() }, { 1.0d, new AlphaParticle(8902002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    