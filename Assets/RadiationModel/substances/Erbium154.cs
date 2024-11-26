using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium154";
        public override double halfLife { get; } = 223.8d;
        public override double atomicWeight { get; } = 153.93279d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9953d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium154() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.0554d, new GammaParticle(511000.0, 0.00243) }, { 0.1661257954d, new GammaParticle(7656.0, 0.16194) }, { 0.2171477190154614d, new GammaParticle(46700.0, 0.02655) }, { 0.38672790563750914d, new GammaParticle(47547.0, 0.02608) }, { 0.12494474233891224d, new GammaParticle(53982.0, 0.02297) }, { 0.15743037534702944d, new GammaParticle(54577.0, 0.02272) }, { 0.03248563300811719d, new GammaParticle(55293.0, 0.02242) } } },
            { 0.004699999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium150() }, { 1.0d, new AlphaParticle(5302002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    