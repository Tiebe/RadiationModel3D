using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium157";
        public override double halfLife { get; } = 0.115d;
        public override double atomicWeight { get; } = 156.95828d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium153() }, { 1.0d, new AlphaParticle(6897002.09) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium157() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    