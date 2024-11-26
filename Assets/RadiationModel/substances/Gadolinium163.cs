using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium163";
        public override double halfLife { get; } = 68.0d;
        public override double atomicWeight { get; } = 162.9341d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium163()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.115d, new GammaParticle(214000.0, 0.00579)), new(0.25d, new GammaParticle(287790.0, 0.00431)), new(0.0625d, new GammaParticle(373370.0, 0.00332)), new(0.03d, new GammaParticle(396400.0, 0.00313)), new(0.02825d, new GammaParticle(575100.0, 0.00216)), new(0.045d, new GammaParticle(632900.0, 0.00196)), new(0.05d, new GammaParticle(1167700.0, 0.00106)), new(0.025d, new GammaParticle(1234400.0, 0.001)), new(0.0325d, new GammaParticle(1311600.0, 0.00095)), new(0.09d, new GammaParticle(1562100.0, 0.00079)), new(0.08d, new GammaParticle(1684500.0, 0.00074)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    