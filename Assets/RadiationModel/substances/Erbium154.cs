using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium154";
        public override double halfLife { get; } = 223.8d;
        public override double atomicWeight { get; } = 153.93279d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9953d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium154()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0554d, new GammaParticle(511000.0, 0.00243)), new(0.1661257954d, new GammaParticle(7656.0, 0.16194)), new(0.2171477190154614d, new GammaParticle(46700.0, 0.02655)), new(0.38672790563750914d, new GammaParticle(47547.0, 0.02608)), new(0.12494474233891224d, new GammaParticle(53982.0, 0.02297)), new(0.15743037534702944d, new GammaParticle(54577.0, 0.02272)), new(0.03248563300811719d, new GammaParticle(55293.0, 0.02242)) } },
            { 0.004699999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium150()), new(1.0d, new AlphaParticle(5302002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    