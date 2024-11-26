using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium134";
        public override double halfLife { get; } = 273024.0d;
        public override double atomicWeight { get; } = 133.90893d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum134()), new(4.4999999999999996e-05d, new GammaParticle(22700.0, 0.05462)), new(0.00058d, new GammaParticle(31890.0, 0.03888)), new(0.00014000000000000001d, new GammaParticle(39080.0, 0.03173)), new(0.000169d, new GammaParticle(54650.0, 0.02269)), new(2.1000000000000002e-06d, new GammaParticle(59040.0, 0.021)), new(2e-05d, new GammaParticle(61300.0, 0.02023)), new(1.6e-05d, new GammaParticle(61880.0, 0.02004)), new(1.2e-06d, new GammaParticle(66260.0, 0.01871)), new(7.6e-06d, new GammaParticle(68550.0, 0.01809)), new(1.21e-05d, new GammaParticle(70850.0, 0.0175)), new(5.4999999999999995e-05d, new GammaParticle(90180.0, 0.01375)), new(9.3e-06d, new GammaParticle(93470.0, 0.01326)), new(0.00025299999999999997d, new GammaParticle(102998.0, 0.01204)), new(2.14e-05d, new GammaParticle(104530.0, 0.01186)), new(6.1000000000000005e-05d, new GammaParticle(107340.0, 0.01155)), new(2.68e-05d, new GammaParticle(116190.0, 0.01067)), new(0.00209d, new GammaParticle(130414.0, 0.00951)), new(0.000171d, new GammaParticle(131930.0, 0.0094)), new(3.76e-05d, new GammaParticle(150200.0, 0.00825)), new(0.000391d, new GammaParticle(158785.0, 0.00781)), new(0.0023d, new GammaParticle(162306.0, 0.00764)), new(0.00012200000000000001d, new GammaParticle(168453.0, 0.00736)), new(5e-06d, new GammaParticle(173380.0, 0.00715)), new(0.00021799999999999999d, new GammaParticle(187013.0, 0.00663)), new(0.000404d, new GammaParticle(193157.0, 0.00642)), new(0.000136d, new GammaParticle(197891.0, 0.00627)), new(1.6100000000000002e-05d, new GammaParticle(200600.0, 0.00618)), new(4.2e-05d, new GammaParticle(205270.0, 0.00604)), new(4.6e-05d, new GammaParticle(220560.0, 0.00562)), new(0.000131d, new GammaParticle(239650.0, 0.00517)), new(3.7000000000000005e-05d, new GammaParticle(252540.0, 0.00491)), new(3.4e-05d, new GammaParticle(262260.0, 0.00473)), new(3.4e-05d, new GammaParticle(262260.0, 0.00473)), new(3.9e-05d, new GammaParticle(265540.0, 0.00467)), new(0.00054d, new GammaParticle(294264.0, 0.00421)), new(0.0008799999999999999d, new GammaParticle(300884.0, 0.00412)), new(0.000156d, new GammaParticle(323590.0, 0.00383)), new(8.800000000000001e-05d, new GammaParticle(355540.0, 0.00349)), new(0.102d, new GammaParticle(5185.0, 0.23912)), new(0.21289999999999998d, new GammaParticle(33034.0, 0.03753)), new(0.391d, new GammaParticle(33442.0, 0.03707)), new(0.1164d, new GammaParticle(37908.0, 0.03271)), new(0.1459d, new GammaParticle(38273.0, 0.03239)), new(0.029500000000000002d, new GammaParticle(38725.0, 0.03202)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    