using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium241";
        public override double halfLife { get; } = 2833920.0d;
        public override double atomicWeight { get; } = 241.05765d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium241()), new(0.00054252d, new GammaParticle(15228.0, 0.08142)), new(0.000297d, new GammaParticle(29020.0, 0.04272)), new(0.002079d, new GammaParticle(32639.0, 0.03799)), new(0.00016830000000000003d, new GammaParticle(41176.0, 0.03011)), new(0.038610000000000005d, new GammaParticle(132413.0, 0.00936)), new(0.00013068d, new GammaParticle(147670.0, 0.0084)), new(0.00019800000000000002d, new GammaParticle(151400.0, 0.00819)), new(0.004356d, new GammaParticle(164800.0, 0.00752)), new(0.0297d, new GammaParticle(165049.0, 0.00751)), new(0.004752d, new GammaParticle(180277.0, 0.00688)), new(0.02673d, new GammaParticle(205879.0, 0.00602)), new(0.00396d, new GammaParticle(265922.0, 0.00466)), new(0.0007920000000000001d, new GammaParticle(298570.0, 0.00415)), new(0.0008613d, new GammaParticle(410800.0, 0.00302)), new(0.006534d, new GammaParticle(417240.0, 0.00297)), new(0.00039600000000000003d, new GammaParticle(430000.0, 0.00288)), new(0.04059d, new GammaParticle(430634.0, 0.00288)), new(0.001188d, new GammaParticle(447350.0, 0.00277)), new(0.012276d, new GammaParticle(463273.0, 0.00268)), new(0.0008514d, new GammaParticle(464360.0, 0.00267)), new(0.7128d, new GammaParticle(471805.0, 0.00263)), new(0.00594d, new GammaParticle(504450.0, 0.00246)), new(0.0001485d, new GammaParticle(595800.0, 0.00208)), new(0.0001188d, new GammaParticle(623100.0, 0.00199)), new(0.015345d, new GammaParticle(636880.0, 0.00195)), new(0.00039600000000000003d, new GammaParticle(652100.0, 0.0019)), new(0.001485d, new GammaParticle(653200.0, 0.0019)), new(0.005742000000000001d, new GammaParticle(670200.0, 0.00185)), new(0.8845538882013364d, new GammaParticle(18078.0, 0.06858)), new(0.22211426260279715d, new GammaParticle(102031.0, 0.01215)), new(0.3496761061127159d, new GammaParticle(106468.0, 0.01165)), new(0.12960581690884962d, new GammaParticle(120157.0, 0.01032)), new(0.174967852826947d, new GammaParticle(121688.0, 0.01019)), new(0.04536203591809737d, new GammaParticle(123677.0, 0.01002)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium237()), new(1.0d, new AlphaParticle(7207102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    