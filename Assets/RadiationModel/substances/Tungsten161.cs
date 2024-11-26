using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten161 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten161";
        public override double halfLife { get; } = 0.409d;
        public override double atomicWeight { get; } = 160.96725d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium157() }, { 1.0d, new AlphaParticle(6947002.09) } } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium161() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    